using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveProject : MonoBehaviour
{
    //we need the current scene value, and the script that has all of the values for the gameplay to set stuff
    //1 is the first gameplay scene, 2 is the next, etc. 

    public int CurrentScene; 

    //sceneNumber is the scene you are on- set it in public editor
    //money is the money value you have
    //prestige is the current prestige
    //beetroot is the last one
    public void SaveGame()
    {
        PlayerPrefs.SetInt("sceneNumber",CurrentScene ); 
    }
}
