using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int LevelsUnloked;
    public Button[] buttons;
    void Start()
    {
        LevelsUnloked = PlayerPrefs.GetInt("levelsunlocked",1);
        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < LevelsUnloked; i++)
        {
            buttons[i].interactable = true;
        }
    }
    public void Lordlevel(int Levelindex)
    {
        SceneManager.LoadScene(Levelindex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
