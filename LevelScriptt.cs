using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScriptt: MonoBehaviour
{
   
    public void pass()
    {
        int currentLevl = SceneManager.GetActiveScene().buildIndex;
        if (currentLevl >= PlayerPrefs.GetInt("levelsunlocked "))
        {
            PlayerPrefs.SetInt("levelsunlocked", currentLevl + 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        Debug.Log("Level" + PlayerPrefs.GetInt("levelsunlocked") + "UNLOCkED");
    }
}
