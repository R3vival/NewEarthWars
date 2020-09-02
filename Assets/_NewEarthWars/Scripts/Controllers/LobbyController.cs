using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NEW.Engine;
using TMPro;

public class LobbyController : MonoBehaviour
{
    [Header("Tanks Factory Components")]
    public GameObject TankPrefab;
    public Transform garaje;
    private TanksFactory tanksFactory;

    public Factions SelectedFactions;

    [SerializeField] List<Tank> tanksCreated;
    string TankName = "";

    private void Start() {

        tanksCreated = new List<Tank>();
        tanksFactory = new TanksFactory();
        SelectedFactions = Factions.Ecother;        
    }

    public void CreateTank() {
        Tank createdTank = tanksFactory.CreateTank(SelectedFactions);
        createdTank.Name = TankName == "" ? SelectedFactions +" Tank" : TankName;

        GarajeTank tank = Instantiate(TankPrefab,garaje).GetComponent<GarajeTank>();
        tank.tank = createdTank;
        tank.SetUp();

    }

    public void SelectFaction(TMP_Dropdown faction) {
        int index = faction.value;
        string selectedFaction = faction.options[index].text;
        switch (selectedFaction) {
            case "Ecother":
                SelectedFactions = Factions.Ecother;
            break;
            case "Entropy":
                SelectedFactions = Factions.Entropy;
                break;
            case "Revelace":
                SelectedFactions = Factions.Revelace;
                break;
            case "Xential":
                SelectedFactions = Factions.Xential;
                break;
        }
    }

    public void SetName(TextMeshProUGUI value) {
        TankName = value.text;
    }
}
