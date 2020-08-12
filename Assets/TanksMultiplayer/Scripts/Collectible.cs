/*  This file is part of the "Tanks Multiplayer" project by Rebound Games.
 *  You are only allowed to use these resources if you've bought them from the Unity Asset Store.
 * 	You shall not license, sublicense, sell, resell, transfer, assign, distribute or
 * 	otherwise make available to any third party the Service or the Content. */

using UnityEngine;

namespace TanksMP
{
    /// <summary>
    /// PLACEHOLDER IMPLEMENTATION. RUN THE NETWORK SETUP!
    /// </summary>
	public class Collectible : MonoBehaviour
	{	        
        public AudioClip useClip;

        [HideInInspector]
        public ObjectSpawner spawner;

        public virtual void OnTriggerEnter(Collider col) { }

        public virtual bool Apply(Player p) { return false; }

        public virtual void OnPickup() { }

        public virtual void OnDrop() { }

        public virtual void OnReturn() { }
    }
}
