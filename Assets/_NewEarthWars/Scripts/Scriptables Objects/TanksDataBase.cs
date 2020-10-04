using NEW.Engine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="NewEarthWars/Tank Manager")]
public class TanksDataBase : ScriptableObject
{
    [SerializeField]
    public List<TankViewer> TanksList = new List<TankViewer>();
}
