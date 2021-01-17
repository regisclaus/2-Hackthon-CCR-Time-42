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
        previousScreen.EnterAnimation();
    }
    
    private void ExitAnimation() {
        switch(exitAnimationMoveSide) {
            case ExitAnimationMoveSide.LEFT:
                doTweenAnimation.DOPlayById("LeftExit");
                break;
            case ExitAnimationMoveSide.DOWN:
                doTweenAnimation.DOPlayById("DownExit");
                break;
            case ExitAnimationMoveSide.NONE:
                break;
        }
    }

    private void EnterAnimation() {
        switch(exitAnimationMoveSide) {
            case ExitAnimationMoveSide.LEFT:
                doTweenAnimation.DOPlayById("LeftExit");
                break;
            case ExitAnimationMoveSide.DOWN:
                doTweenAnimation.DOPlayById("DownExit");
                break;
            case ExitAnimationMoveSide.NONE:
                break;
        }
    }

}

[Serializable]
public enum ExitAnimationMoveSide {
    LEFT,
    DOWN,
    NONE
}