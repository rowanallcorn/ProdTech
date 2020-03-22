using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics; 

public class VariableAffects : MonoBehaviour
{
    public Text money;
    public Text prestige;
    public Text beetroot;

    [Tooltip("The current money value of the scene")]
    public int moneyValue;
    [Tooltip("The current prestige value of the scene")]
    public int prestigeValue;
    [Tooltip("The current beetroot value of the scene")]
    public int beetrootValue;

    //SceneCurrent is the scene you are on- set it in public editor
    //money is the money value you have
    //prestige is the current prestige
    //beetroot is the last one
    private void Start()
    {
        //assign the scene save data to the current scene and update the variables to the new value
        PlayerPrefs.SetString("SceneCurrent", SceneManager.GetActiveScene().name);
        moneyValue = PlayerPrefs.GetInt("money");
        prestigeValue = PlayerPrefs.GetInt("prestige");
        beetrootValue = PlayerPrefs.GetInt("beetroot");

        //update the text to reflect this update
        money.text = ("Money: " + moneyValue + "/10");
        prestige.text = ("Prestige: " + prestigeValue + "/10");
        beetroot.text = ("Beetroot: " + beetrootValue + "/10");
    }

    /// <summary>
    /// updates the old variables using numbers supplied by the fungus. the variables are the CHANGE in variable, not the new one. 
    /// </summary>
    /// <param name="moneyChange"></param>
    /// the amount to change the money by
    /// <param name="prestigeChange"></param>
    /// same as above
    /// <param name="beetrootChange"></param>
    /// same as above
    public void updateVariableValues(int moneyChange, int prestigeChange, int beetrootChange)
    {
        moneyValue = moneyValue + moneyChange;
        prestigeValue = prestigeValue+ prestigeChange;
        beetrootValue = beetrootValue+ beetrootChange; 

        money.text = ("Money: " + moneyValue + "/10");
        prestige.text = ("Prestige: " + prestigeValue + "/10");
        beetroot.text = ("Beetroot: " + beetrootValue + "/10");

        if (moneyValue <= 0 || prestigeValue <= 0 || beetrootValue <= 0)
        {
            PlayerPrefs.SetString("SceneCurrent", "LoseScene");
            SceneManager.LoadScene("LoseScene"); }

        Analytics.CustomEvent("Money Change", new Dictionary<string, object>
        {  { "Money Change", moneyChange},
            { "Prestige Change", prestigeChange},
            { "Beetroot Change", beetrootChange},
            { "Scene Name", SceneManager.GetActiveScene().name}
        }); 
                

        PlayerPrefs.SetInt("money", moneyValue);
        PlayerPrefs.SetInt("prestige", prestigeValue);
        PlayerPrefs.SetInt("beetroot", beetrootValue);

    }

}