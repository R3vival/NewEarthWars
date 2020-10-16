using NEW.Engine;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//Uncomment the next line to hide the script in the inspector
//[HideMonoScript]
public class LoaderManager : MonoBehaviour
{
    [Required]
    public Scenes currentScene;
    [Required]
    public TextMeshProUGUI progressText;

    [HideInInspector]
    public delegate void ProgressDelegate(float progress);
    

    //If need something on loadLevel, uncomment this function
    //private voeid OnLevelWasLoaded(int level) {
    ////    Conditional that compare the level loaded with the int in Scenes Enum
    ////    uncomment this if is needed or create ur own switch
    ////    if(lvel == (int)Scenes.Lobby) {
    ////    }
    //}

    public void LoadScene(Scenes sceneToLoad) {
        switch (sceneToLoad) {
            case Scenes.Loader:
                StartCoroutine(LoadSceneAsync(Scenes.Loader.ToString(), OnLoadLevelProgressUpdate));
                break;
            case Scenes.Lobby:
                StartCoroutine(LoadSceneAsync(Scenes.Lobby.ToString(), OnLoadLevelProgressUpdate));
                break;
            case Scenes.CharacterSelect:
                StartCoroutine(LoadSceneAsync(Scenes.CharacterSelect.ToString(), OnLoadLevelProgressUpdate));
                break;
            case Scenes.Gameplay:
                StartCoroutine(LoadSceneAsync(Scenes.Gameplay.ToString(), OnLoadLevelProgressUpdate));
                break;
        }
    }

    public static IEnumerator LoadSceneAsync(string nextLevel, ProgressDelegate progressDelegate) {
        AsyncOperation async = SceneManager.LoadSceneAsync(nextLevel);

        while (!async.isDone) {
            progressDelegate(async.progress);
            async.allowSceneActivation = async.progress > 0.8f;
            yield return null;
        }

    }

    private void OnLoadLevelProgressUpdate(float progress) {
        progressText.text = (int)progress + " %";

    }
    
    public enum Scenes {
        Loader,
        Lobby,
        CharacterSelect,
        Gameplay
    }
}
