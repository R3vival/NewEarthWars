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
	public class ObjectSpawner : MonoBehaviour
	{
		public GameObject prefab;
        public bool respawn;
		public int respawnTime;
        
        [HideInInspector]
        public GameObject obj;

        [HideInInspector]
        public CollectionType colType = CollectionType.Use;

        public void Instantiate() {}
        public void Pickup() { }
        public void Drop(Vector3 position) { }
        public void Return() { }
        public void Destroy() { }
        public void SetRespawn() { }
    }


    public enum CollectionType
    {
        Use,
        Pickup
    }
}