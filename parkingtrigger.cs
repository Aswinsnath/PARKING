using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parkingtrigger : MonoBehaviour
{
    public Canvas canvasObject; // Reference to the Canvas object in the scene

    void Start()
    {
        
        /*canvasObject = FindObjectOfType<Canvas>();

        
        canvasObject.gameObject.SetActive(false);*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Turn on the Canvas object
            canvasObject.gameObject.SetActive(true);
        }
    }
}
