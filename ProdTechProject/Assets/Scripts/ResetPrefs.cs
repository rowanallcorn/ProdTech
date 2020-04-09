using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPrefs : MonoBehaviour
{

    //declare staring variables
    public int MoneySt;
    public int prestSt;
    public int beetSt;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            resetAllPrefs();
        }
    }

    public void resetAllPrefs()

        //set all variable values to the public values listed above, and set the scene back to introduciton
    {
        PlayerPrefs.SetInt("money", MoneySt);
        PlayerPrefs.SetInt("prestige", prestSt);
        PlayerPrefs.SetInt("beetroot", beetSt);

        PlayerPrefs.SetString("SceneCurrent", "Introduction"); 

    }
}
