using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Level;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Back1()
    {
        Mainmenu.SetActive(true);
        Level.SetActive(false);
    }
}
