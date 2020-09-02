using NEW.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NEW.Engine {
    public class XentialTank : Tank {
        public XentialTank() {
            this.Faction = Factions.Xential;
            this.BaseColor = Color.red;
        }
        public override void RechargedShoot() {
            Debug.Log("bipbipbip");
        }
    }

}