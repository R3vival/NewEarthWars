using NEW.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NEW.Engine {
    public class EntropyTank : Tank {
        public EntropyTank() {
            this.Faction = Factions.Entropy;
            this.BaseColor = Color.blue;
        }
        public override void RechargedShoot() {
            Debug.Log("RashoLaser");
        }
    }
}

