using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AtividadeVideoScript : MonoBehaviour
{

    [SerializeField] private VideoPlayer videoPlayer;

    private void Start() {
        videoPlayer.time = 15f;
    }

    public void PlayVideo() {
        videoPlayer.Play();
    }

    public void PauseVideo() {
        videoPlayer.Pause();
    }
}
