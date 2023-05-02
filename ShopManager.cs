/*


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int CurrentcarIndex = 0;
    public GameObject[] carModels;

    public CarBluePrint[] carss;
    public Button buybutton;
    public TextMeshProUGUI coinText;

    private string coinKey = "coinCount";

    void Start()
    {
      
        CurrentcarIndex = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach (GameObject car in carModels)
            car.SetActive(false);
        carModels[CurrentcarIndex].SetActive(true);

       
        foreach (CarBluePrint car in carss)
        {
            if (car.Prise == 0)
                car.isunloked = true;
            else
                car.isunloked = PlayerPrefs.GetInt(car.name, 0) == 0 ? false : true;
        }

     
        UpdateUI();
    }

    
    void Update()
    {
        UpdateUI();
    }

    public void changeIndex()
    {
        carModels[CurrentcarIndex].SetActive(false);
        CurrentcarIndex++;
        if (CurrentcarIndex == carModels.Length)
            CurrentcarIndex = 0;
        carModels[CurrentcarIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedCar", CurrentcarIndex);
    }


    public void changePrivious()
    {
        carModels[CurrentcarIndex].SetActive(false);
        CurrentcarIndex--;
        if (CurrentcarIndex == -1)
            CurrentcarIndex = carModels.Length - 1;
        carModels[CurrentcarIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedCar", CurrentcarIndex);
    }

    private void UpdateUI()
    {
       
        CarBluePrint c = carss[CurrentcarIndex];
        if (c.isunloked)
        {
            buybutton.gameObject.SetActive(false);
        }
        else
        {
            buybutton.gameObject.SetActive(true);
            buybutton.GetComponentInChildren<TextMeshProUGUI>().text = "Buy-" + c.Prise;
            int coinCount = PlayerPrefs.GetInt(coinKey, 0);
            coinText.text = coinCount.ToString();
            if (coinCount >= c.Prise)
            {
                buybutton.interactable = true;
            }
            else
            {
                buybutton.interactable = false;
            }
        }
    }

    public void BuyCar()
    {
       
        int coinCount = PlayerPrefs.GetInt(coinKey, 0);
        CarBluePrint c = carss[CurrentcarIndex];
        coinCount -= c.Prise;
        PlayerPrefs.SetInt(coinKey, coinCount);
        PlayerPrefs.SetInt(c.name, 1);
        c.isunloked = true;

       
        UpdateUI();
    }
}
*/






using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int CurrentcarIndex = 0;
    public GameObject[] carModels;

    public CarBluePrint[] carss;
    public Button buybutton;
    public TextMeshProUGUI coinText;

    private string coinKey = "coinCount";

    void Start()
    {
        // Set the current car index and activate the corresponding car model
        CurrentcarIndex = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach (GameObject car in carModels)
            car.SetActive(false);
        carModels[CurrentcarIndex].SetActive(true);

        // Check if the current car has been purchased before
        string carKey = "Car" + CurrentcarIndex;
        if (PlayerPrefs.GetInt(carKey, 0) == 1)
        {
            // The car has been purchased before, so unlock it
            carss[CurrentcarIndex].isunloked = true;
        }
        else
        {
            // The car has not been purchased before, so lock it
            carss[CurrentcarIndex].isunloked = false;
        }

        // Update the UI
        UpdateUI();
    }


    void Update()
    {
        // Update the UI every frame
        UpdateUI();
    }

    public void changeIndex()
    {
        // Switch to the next car model
        carModels[CurrentcarIndex].SetActive(false);
        CurrentcarIndex++;
        if (CurrentcarIndex == carModels.Length)
            CurrentcarIndex = 0;
        carModels[CurrentcarIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedCar", CurrentcarIndex);
    }

    public void changePrivious()
    {
        // Switch to the previous car model
        carModels[CurrentcarIndex].SetActive(false);
        CurrentcarIndex--;
        if (CurrentcarIndex == -1)
            CurrentcarIndex = carModels.Length - 1;
        carModels[CurrentcarIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedCar", CurrentcarIndex);
    }

    private void UpdateUI()
    {
        // Update the UI based on the current car's unlock status and price
        CarBluePrint c = carss[CurrentcarIndex];
        if (c.isunloked)
        {
            buybutton.gameObject.SetActive(false);
        }
        else
        {
            buybutton.gameObject.SetActive(true);
            buybutton.GetComponentInChildren<TextMeshProUGUI>().text = "Buy-" + c.Prise;
            int coinCount = PlayerPrefs.GetInt(coinKey, 0);
            coinText.text = coinCount.ToString();
            if (coinCount >= c.Prise)
            {
                buybutton.interactable = true;
            }
            else
            {
                buybutton.interactable = false;
            }
        }
    }

    public void BuyCar()
    {
        // Deduct the price of the current car from the player's coin count and unlock the car
        int coinCount = PlayerPrefs.GetInt(coinKey, 0);
        CarBluePrint c = carss[CurrentcarIndex];
        coinCount -= c.Prise;
        PlayerPrefs.SetInt(coinKey, coinCount);
        string carKey = "Car" + CurrentcarIndex;
        PlayerPrefs.SetInt(carKey, 1); // Set the car key to 1 to unlock the car
        c.isunloked = true;

        // Update the UI
        UpdateUI();
    }

}
