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
        if (PlayerPrefs.GetString("SceneCurrent")==null)
        { PlayerPrefs.SetString("SceneCurrent", "Introduction"); }
    }
    public void StartAtLastScene()
    {   if (PlayerPrefs.GetString("SceneCurrent") == "Introduction")
        {
            PlayerPrefs.SetInt("money", MoneySt);
            PlayerPrefs.SetInt("prestige", prestSt);
            PlayerPrefs.SetInt("beetroot", beetSt);
        }

        SceneManager.LoadScene(PlayerPrefs.GetString("SceneCurrent"));  }
}
