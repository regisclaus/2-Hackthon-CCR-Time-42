using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class ScreenScript : MonoBehaviour
{

    [SerializeField] public ExitAnimationMoveSide exitAnimationMoveSide = ExitAnimationMoveSide.LEFT;
    [SerializeField] public ScreenScript parentScreen;

    // [SerializeField] public ScreenScript previosScreen;

    [Header("Internal References")]
    public DOTweenAnimation doTweenAnimation;

    private void Awake() {
        doTweenAnimation = GetComponent<DOTweenAnimation>();
    }

    public void GoToNextScreen(GameObject nextScreen) {
        nextScreen.SetActive(true);
        parentScreen?.ExitAnimation();
        ExitAnimation();
    }

    public void GoToPreviousScreen(ScreenScript previousScreen) {
        previousScreen.gameObject.SetActive(true);
        previousScreen.EnterAnimation(this.gameObject);
  
    }
    
    public void ExitAnimation() {
        switch(exitAnimationMoveSide) {
            case ExitAnimationMoveSide.LEFT:
                doTweenAnimation.DORestartById("LeftExit");
                break;
            case ExitAnimationMoveSide.DOWN:
                doTweenAnimation.DORestartById("DownExit");
                break;
            case ExitAnimationMoveSide.NONE:
                break;
        }
    }

    public void EnterAnimation(GameObject screenCaller) {
        StartCoroutine(EnterAnimationCorrotine(screenCaller));
    }

    private IEnumerator EnterAnimationCorrotine(GameObject screenCaller) {
        switch(exitAnimationMoveSide) {
            case ExitAnimationMoveSide.LEFT:
                doTweenAnimation.DOPlayBackwardsById("LeftExit");
                break;
            case ExitAnimationMoveSide.DOWN:
                doTweenAnimation.DOPlayBackwardsById("DownExit");
                break;
            case ExitAnimationMoveSide.NONE:
                break;
        }

        while(doTweenAnimation.tween.IsPlaying()) {
            yield return null;
        }


        screenCaller.SetActive(false);
    }



}

[Serializable]
public enum ExitAnimationMoveSide {
    LEFT,
    DOWN,
    NONE
}