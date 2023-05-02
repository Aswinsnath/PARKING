using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    public GameObject object1; // Reference to the first game object
    public GameObject object2; // Reference to the second game object

    void Start()
    {
        // Make sure the second game object is turned off at the start of the game
        object2.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Turn off the first game object
            object1.SetActive(false);

            // Turn on the second game object
            object2.SetActive(true);
        }
    }
}