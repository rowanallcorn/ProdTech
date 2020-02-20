﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
   public void PlayAgain()
    {
        SceneManager.LoadScene("StartScene"); // loads main menu
    }

    public void Quit()
    {
        Application.Quit(); // quits the application

    }
}
