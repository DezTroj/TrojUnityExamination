using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;
public class KeyBind : MonoBehaviour
{
    public InputActionAsset trojsPlayerAction;
    public Animator trojsAnimator;

    private void Update()
    {
        if (trojsPlayerAction.FindAction("Move").IsPressed())
        {
            trojsAnimator.SetBool("Walk", true);
        }

        else
        
            trojsAnimator.SetBool("Walk", false);
        if (trojsPlayerAction.FindAction("Jump").IsPressed())
        {
            trojsAnimator.SetBool("Jump", true);
        }

        else
        
            trojsAnimator.SetBool("Jump", false);

    }
}
