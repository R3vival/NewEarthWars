using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NEW.Engine {
    public class EcotherTank : Tank {
        public EcotherTank() {
            this.Faction = Factions.Ecother;
            this.BaseColor = Color.green;
        }
        public override void RechargedShoot() {
            Debug.Log("tatatatatata");
        }
    }
}
