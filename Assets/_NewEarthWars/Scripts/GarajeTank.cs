using TMPro;
using UnityEngine;
using UnityEngine.UI;
using NEW.Engine;

public class GarajeTank : MonoBehaviour
{
    public Tank tank;

    public MeshRenderer[] Renderers;


    public TextMeshProUGUI Name;
    public Slider Health;
    public TextMeshProUGUI HealthText;
    public Slider Energy;
    public TextMeshProUGUI EnergyText;
    public Slider Damage;
    public TextMeshProUGUI DamageText;
    public Slider Speed;
    public TextMeshProUGUI SpeedText;
    public Slider Range;
    public TextMeshProUGUI RangeText;

    public void SetUp() {
        //Setup Name
        this.Name.text = tank.Name;
        Health.maxValue = tank.MaxHealth;
        Health.value= tank.Health;

        HealthText.text = Health.value + " pts";
        //Setup Energy
        Energy.value = tank.Energy;
        EnergyText.text = Energy.value + " pts";
        //Setup Damage
        Damage.value = tank.Damage;
        DamageText.text = Damage.value + " pts";
        //Setup Speed
        Speed.value = tank.Speed;
        SpeedText.text = Speed.value + " pts";
        //Setup Range
        Range.value = tank.Range;
        RangeText.text = Range.value + " pts";

        for (int i = 0; i < Renderers.Length; i++)
            Renderers[i].materials[0].color = tank.BaseColor;
    }

}
