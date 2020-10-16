using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    public string stringAudio;

    public void PlayAudio() {
        NewEarthWarsGameManager.instance.audioManager.PlayOneShot(stringAudio);
    }
}
