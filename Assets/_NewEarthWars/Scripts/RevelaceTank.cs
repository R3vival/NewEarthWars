using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NEW.Engine {
    public class RevelaceTank : Tank {
        public RevelaceTank() {
            this.Faction = Factions.Revelace;
            this.BaseColor = Color.black;
        }
        public override void RechargedShoot() {
            Debug.Log("Swushhh");
        }
    }
}
