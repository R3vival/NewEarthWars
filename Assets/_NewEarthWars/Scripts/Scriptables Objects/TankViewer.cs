using NEW.Engine;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "NewEarthWars/Tank")]
public class TankViewer : ScriptableObject {

    public string Name;
    [Header("Tank Stats")]
    
    public int MaxHealth=100;
    [HorizontalGroup("Attributes")]    

    [VerticalGroup("Attributes/StatsA"), LabelWidth(50)]
    [PropertyRange(0,"MaxHealth")]
    public int Health;
    [VerticalGroup("Attributes/StatsA"), LabelWidth(50)]
    public bool Alive;

    [VerticalGroup("Attributes/StatsA"), LabelWidth(50)]
    [PropertyRange(0, 3)]
    public int Energy;

    [VerticalGroup("Attributes/StatsB"), LabelWidth(50)]
    public int Speed;
    [VerticalGroup("Attributes/StatsB"), LabelWidth(50)]
    public int Damage;
    [VerticalGroup("Attributes/StatsB"), LabelWidth(50)]
    public int Range;

    public Factions Faction;
    public Color BaseColor;    
}
