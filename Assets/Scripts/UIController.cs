using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] RawImage background;
    bool isShowing = true;

    void Update() 
    {
        if (isShowing == true)
        {
            background.CrossFadeAlpha(1, 1.0f, false);
        }
        if (isShowing == false)
        {
            background.CrossFadeAlpha(0, 1.0f, false);
        }
    }
    
    public void ToggleBackground()
    {
        isShowing = !isShowing;
    }
}
