using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NEW {
    public class PortalControllers : MonoBehaviour {
        public static PortalControllers instance;
        public List<Portal> portalsList = new List<Portal>();

        [HideInInspector]
        public UsePortal portalEvent = new UsePortal();
        private void Awake() {
            if (instance == null)
                instance = this;
            else
                Destroy(this);

            portalEvent.AddListener(Notify);
        }
        public void Notify(GameObject tank) {
            foreach(Portal portal in portalsList) {
                portal.Teleport(tank);
            }
        }
    }
}