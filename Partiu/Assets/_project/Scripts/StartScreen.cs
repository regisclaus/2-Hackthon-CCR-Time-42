using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ScreenScript))]
public class StartScreen : MonoBehaviour
{
    [SerializeField] public GameObject nextScreen;
    [SerializeField] private float timeNextScreen = 2.0f;

    void Start()
    {
        Invoke("GoToNextScreen", timeNextScreen);
    }

    private void GoToNextScreen() {
        GetComponent<ScreenScript>().GoToNextScreen(nextScreen);
    }
}
