using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

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


    /// <summary>
    /// updates the old variables using numbers supplied by the fungus. the variables are the CHANGE in variable, not the new one. 
    /// </summary>
    /// <param name="moneyChange"></param>
    /// <param name="prestigeChange"></param>
    /// <param name="beetrootChange"></param>
    void updateVariableValues(int moneyChange, int prestigeChange, int beetrootChange)
    {
        moneyValue += moneyChange;
        prestigeValue += prestigeChange;
        beetrootValue += beetrootChange; 

        money.text = ("Money: " + moneyValue + "/10");
        prestige.text = ("Prestige: " + prestigeValue + "/10");
        beetroot.text = ("Money: " + beetrootValue + "/10");

        if (moneyValue == 0 || prestigeValue == 0 || beetrootValue == 0)
            SceneManager.LoadScene("LoseScene");

    }

}