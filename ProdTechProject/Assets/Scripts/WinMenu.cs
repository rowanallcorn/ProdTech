using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            PlayAgain();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            Quit();
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("StartScene"); // loads main menu
    }

    public void Quit()
    {
        Application.Quit(); // quits the application

    }

}
