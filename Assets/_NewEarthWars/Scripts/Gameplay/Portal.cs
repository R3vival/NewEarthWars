using System.Collections;
using System.Collections.Generic;
using TanksMP;
using UnityEngine;

namespace NEW
{
    public interface IPortal
    {
        void Teleport(GameObject tank,bool enter);
    }
    public class Portal : MonoBehaviour, IPortal
    {
        public int portalId;

        public void Teleport(GameObject tank,bool enter)
        {
            Player tankPlayer = tank.GetComponent<Player>();
            if (enter)
                tankPlayer.canMove = tankPlayer.canShoot = false;
        }
    }
}