using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
    public GameObject shop;
    public GameObject levls;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Playy()
    {
        ShopManager shopManager = FindObjectOfType<ShopManager>();
        CarBluePrint currentCar = shopManager.carss[shopManager.CurrentcarIndex];
        if (currentCar.isunloked)
        {
            shop.SetActive(false);
            levls.SetActive(true);
        }
        else
        {
            Debug.Log("The selected car is locked. Please unlock it to play.");
        }
    }
}
