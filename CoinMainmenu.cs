using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinMainmenu : MonoBehaviour
{
    public Text coinText;
    private string coinKey = "coinCount";

    void Start()
    {
        try
        {
            // Load the coin count from PlayerPrefs and update the UI display
            int coinCount = PlayerPrefs.GetInt(coinKey, 0);
            coinText.text = coinCount.ToString();
        }
        catch (PlayerPrefsException ex)
        {
            Debug.LogError("Error loading coin count: " + ex.Message);
        }
    }

    public void AddCoins(int amount)
    {
        try
        {
            // Add the specified amount of coins to the coin count in PlayerPrefs
            int coinCount = PlayerPrefs.GetInt(coinKey, 0);
            coinCount += amount;
            PlayerPrefs.SetInt(coinKey, coinCount);

            // Update the UI display
            coinText.text = coinCount.ToString();
        }
        catch (PlayerPrefsException ex)
        {
            Debug.LogError("Error adding coins: " + ex.Message);
        }
    }

    public void DeductCoins(int amount)
    {
        try
        {
            // Deduct the specified amount of coins from the coin count in PlayerPrefs
            int coinCount = PlayerPrefs.GetInt(coinKey, 0);
            coinCount -= amount;
            PlayerPrefs.SetInt(coinKey, coinCount);

            // Update the UI display
            coinText.text = coinCount.ToString();
        }
        catch (PlayerPrefsException ex)
        {
            Debug.LogError("Error deducting coins: " + ex.Message);
        }
    }
}
