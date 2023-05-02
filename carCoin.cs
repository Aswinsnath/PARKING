using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carCoin : MonoBehaviour
{
    public int points = 0;
    public int numberofcoin;
    public Text coinText;

    private string coinKey = "coinCount";

    public void Start()
    {
        // Load the coin count from PlayerPrefs
        numberofcoin = PlayerPrefs.GetInt(coinKey, 0);

        // Update the UI display with the loaded value
        UpdateCoinDisplay();
    }

    void UpdateCoinDisplay()
    {
        coinText.text = numberofcoin.ToString();
    }

    void OnApplicationQuit()
    {
        // Save the coin count to PlayerPrefs
        PlayerPrefs.SetInt(coinKey, numberofcoin);
        PlayerPrefs.Save();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Increment the coin count
            numberofcoin++;

            // Update the UI display
            UpdateCoinDisplay();

            // Save the coin count to PlayerPrefs
            PlayerPrefs.SetInt(coinKey, numberofcoin);
            PlayerPrefs.Save();

            // Destroy the coin game object
            Destroy(gameObject);
        }
    }

}
