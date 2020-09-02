using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NEW.Engine {
    public class TanksFactory{

        public Tank CreateTank(Factions faction ) {
            switch (faction) {
                case Factions.Ecother:
                    return new EcotherTank();
                case Factions.Xential:
                    return new XentialTank();
                case Factions.Revelace:
                    return new RevelaceTank();
                case Factions.Entropy:
                    return new EntropyTank();
                default:
                    return null;
            }
        }
    }
}
