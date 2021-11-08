using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] RawImage background;
    bool isShowing = true;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject backButton;

    void Update() 
    {
        if (isShowing == true)
        {
            //background.CrossFadeAlpha(1, 1.0f, false);
            background.gameObject.SetActive(true);
        }
        if (isShowing == false)
        {
            //background.CrossFadeAlpha(0, 1.0f, false);
            background.gameObject.SetActive(false);
        }
    }
    
    public void StartButton()
    {
        isShowing = !isShowing;
        startButton.SetActive(false);
        backButton.SetActive(true);
    }

    public void BackButton()
    {
        isShowing = !isShowing;
        backButton.SetActive(false);
        startButton.SetActive(true);
    }
}
