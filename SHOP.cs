using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHOP : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject shop;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void SHOPP()
    {
        Canvas.SetActive(false);
        shop.SetActive(true);
    }
}
