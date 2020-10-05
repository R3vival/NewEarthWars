using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewEarthWarsGameManager : MonoBehaviour {
    [HideInInspector]
    public static NewEarthWarsGameManager instance;

    //To load a New Scene 
    [Required]
    public LoaderManager loaderManager;

    [ShowInInspector]
    private GameState currentState;

    private void Awake() {
        //Singleton
        if (instance != null)
            Destroy(this);
        else
            instance = this;    
            

        SwitchState(GameState.Index);
    }
    private void Start() {
        if (currentState == GameState.Index)
            loaderManager.LoadScene(LoaderManager.Scenes.Lobby);
    }

    public GameState GetGameState() {
        return currentState;
    }

    public void SwitchState(GameState state) {
        currentState = state;
    }

    public enum GameState{
        Index,
        Lobby
    }
}
