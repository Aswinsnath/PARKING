using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour
{
    public int CurrentcarIndex = 0;
    public GameObject[] cars;
    void Start()
    {
        CurrentcarIndex = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach (GameObject car in cars)
            car.SetActive(false);
        cars[CurrentcarIndex].SetActive(true);
    }
}
