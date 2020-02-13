using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPrefs : MonoBehaviour
{
    public int MoneySt;
    public int prestSt;
    public int beetSt; 

    public void resetAllPrefs()
    {
        PlayerPrefs.SetInt("money", MoneySt);
        PlayerPrefs.SetInt("prestige", prestSt);
        PlayerPrefs.SetInt("beetroot", beetSt);

        PlayerPrefs.SetString("SceneCurrent", "Introduction"); 

    }
}
