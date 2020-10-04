using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NEW.Engine {
    public abstract class Tank : MonoBehaviour {

        #region Declarations
        private string tankName;
        private int health;
        private int maxHealth;
        [Range(1,3)]
        private int energy;
        private float speed;
        private int damage;
        private int range;
        private bool alive;
        private Factions faction;
        private Color baseColor;
        #endregion

        #region Encapsulamiento
        //Encapsulamiento de todas las variables Privadas del tank
        public string Name { get => tankName; set => tankName = value; }
        public int Health { get => this.health; set => this.health = value >= 0 ?
                /*preguntamos si el rango de vida es mayor o igual a 0*/ 
                value <= MaxHealth ?
                /*preguntamos si el rango de vida es menor o igual a la vida maxima*/ 
                value : MaxHealth : 0;}
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public int Energy { get => energy; set => energy = value; }
        public float Speed { get => speed; set => speed = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Range { get => range; set => range = value; }
        public bool Alive { get => alive; }
        public Factions Faction { get => faction; set => faction = value; }
        public Color BaseColor { get => baseColor; set => baseColor = value; }
        
        #endregion

        #region Constructor
        public Tank() {
            this.tankName = "Tank";            
            this.maxHealth = 100;
            this.health = maxHealth;
            this.energy = 3;
            this.speed = 5f;
            this.damage = 10;
            this.range = 20;
        }
        public Tank(string name){
            this.tankName = name;
        }
        #endregion

        #region Tank Functions
        public void LoseHealth(int hitPoint) {

            health -= hitPoint;
        }
        public void GainHealth(int healthPoint) {            
            health += healthPoint;
        }
        public void Dead() {
            if(health<=0)
                alive = false;
        }

        public void Revive() {
            alive = true;
        }

        public void Shoot() {
            Debug.Log("PIu piu piu");
        }
        public abstract void RechargedShoot();
        public void Move() {
            Debug.Log("rum rum");
        }
        public void GainEnergy() {
            Debug.Log("moto moto");
        }
        public void SpentEnergy() {
            Debug.Log("iugh");
        }
        
        #endregion
    }

    public enum Factions {
        Ecother,
        Xential,
        Revelace,
        Entropy
    }
}

