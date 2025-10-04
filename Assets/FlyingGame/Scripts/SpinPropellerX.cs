using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 1000f; // Speed of propeller rotation

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around the Z axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}