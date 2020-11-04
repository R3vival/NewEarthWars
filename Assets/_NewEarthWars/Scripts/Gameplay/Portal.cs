using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TanksMP;
using UnityEngine;
using UnityEngine.Events;

namespace NEW
{
    [SerializeField]
    public class UsePortal : UnityEvent<GameObject> {

    }
    public interface IPortal
    {
        void Teleport(GameObject tank);
    }
    public class Portal : MonoBehaviour, IPortal
    {
        public Transform tpPosition;
        public int portalId;
        [Header("Teleport Time")]
        [Tooltip("Time in seconds")]
        public int time;
        [Header("Cooldown Time")]
        [Tooltip("Time in seconds")]
        public int cooldownTime;

        [Header("Enable/Disable materials")]
        public Material enabledMat;
        public Material disabledMat;

        [Header("Renderer")]
        public Renderer portalRenderer;

        float cooldown;
        private bool enter, available;
        public UsePortal UsePortal;

        private void Start() {
            UsePortal = PortalControllers.instance.portalEvent;
        }
        private void Update() {
            if (cooldown >= cooldownTime) {
                available = true;
                portalRenderer.material = enabledMat;
            }                
            else {
                available = false;
                portalRenderer.material = disabledMat;
            }

            cooldown +=Time.deltaTime;
        }
        private void OnTriggerEnter(Collider other) {
            if (other.GetComponent<Player>() || other.GetComponent<PlayerBot>()) {
                enter = true;
                UsePortal.Invoke(other.gameObject);
            }            
        }
        public void Teleport(GameObject tank)
        {
            if (available) {
                GetComponent<Collider>().enabled = false;
                StartCoroutine(UseTeleport(tank));
                GetComponent<Collider>().enabled = true;
                enter = false;
                cooldown = 0;
            }            
        }
        IEnumerator UseTeleport(GameObject tank) {
            Player tankPlayer = tank.GetComponent<Player>();

            if (enter) {
                tankPlayer.canMove = tankPlayer.canShoot = false;
                HideShowTank(tank, false);
            } else {
                yield return new WaitForSeconds(time);
                tank.transform.position = tpPosition.position;
                HideShowTank(tank,true);
                tankPlayer.canMove = tankPlayer.canShoot = true;
            }
        }
        void HideShowTank(GameObject tank, bool value) {
            tank.GetComponent<Rigidbody>().useGravity = value;
            Player tankPlayer = tank.GetComponent<Player>();
            
            foreach (Renderer renderer in tankPlayer.renderers) {
                renderer.enabled = value;
            }
            tank.transform.Find("BlobShadow").GetComponent<SpriteRenderer>().enabled = value;
            tank.GetComponent<Collider>().enabled = value;
        }
    }
}
