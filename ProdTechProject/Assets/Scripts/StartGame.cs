using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class StartGame : MonoBehaviour
{

    public int MoneySt;
    public int prestSt;
    public int beetSt;

    private void Start()
    {
        //if there is no scene prefab set yet, set it to introduction
        if (PlayerPrefs.GetString("SceneCurrent")==null)
        { PlayerPrefs.SetString("SceneCurrent", "Introduction"); }
    }

    //start the game- if the game is still in the introduction scene, set the values of the game stats 
    // to starting values. Otherwise, load the scene the player was last on. 
    public void StartAtLastScene()
    {   if (PlayerPrefs.GetString("SceneCurrent") == "Introduction")
        {
            PlayerPrefs.SetInt("money", MoneySt);
            PlayerPrefs.SetInt("prestige", prestSt);
            PlayerPrefs.SetInt("beetroot", beetSt);
        }

        SceneManager.LoadScene(PlayerPrefs.GetString("SceneCurrent"));  }
}
