using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Input_Actions inputActions;
    public static InputManager instance;

    //Singleton
    private void Awake()
    {
        if (instance == null)
        {
            inputActions = new Input_Actions();
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
