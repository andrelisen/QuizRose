﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sair : MonoBehaviour
{
   
    public void QuitGame () {
            Application.Quit ();
            Debug.Log("Game is exiting");
        //Just to make sure its working
    }
}