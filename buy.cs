using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buy : MonoBehaviour
{
    public Text moneyText;
    public int playerMoney = 50; // Starting amount of money
    public int cost = 10; // the cost of the product


    void Start()
    {
        UpdateMoneyDisplay();
    }

    public void BuyProduct()
    {
        if (playerMoney >= cost)
        {
            // Subtract the cost from the player's money and update the UI display
            playerMoney -= cost;
            UpdateMoneyDisplay();

            // TODO: Add logic for actually buying the product (e.g. unlocking it)

            Debug.Log("Product bought!");
        }
        else
        {
            Debug.Log("Not enough money!");
        }
    }

    void UpdateMoneyDisplay()
    {
        moneyText.text = "Money: " + playerMoney.ToString();
    }
}

