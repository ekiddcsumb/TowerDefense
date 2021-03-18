using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Purse : MonoBehaviour
{
    public GameObject cointText;
    public int coins = 100;

    public void AddCoin(int coin)
    {
        coins += coin;
    }

    public void RemoveCoin(int coin)
    {
        coins -= coin;
    }

    private void DisplayCoins()
    {
        cointText.GetComponent<Text>().text = coins.ToString();
    }

    private void Update()
    {
        DisplayCoins();
    }
}
