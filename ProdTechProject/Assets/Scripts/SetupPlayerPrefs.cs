using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupPlayerPrefs : MonoBehaviour
{
    //set variables
    [Tooltip("The start money value of the game")]
    public int moneyStart;
    [Tooltip("The start prestige value of the game")]
    public int prestigeStart;
    [Tooltip("The start beetroot value of the game")]
    public int beetrootStart;
    // Start is called before the first frame update
    void Start()
    {
        //set saved values to the established variables above
        PlayerPrefs.SetInt("money", moneyStart);
        PlayerPrefs.SetInt("prestige", prestigeStart);
        PlayerPrefs.SetInt("beetroot", beetrootStart);

    }

}
