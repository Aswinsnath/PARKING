using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed = 50f;
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0); 
    }
}
