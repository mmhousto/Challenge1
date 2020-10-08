using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class RotatePropellerX : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //rotates propeller
        transform.Rotate(0.0f, 0.0f, 25.0f, Space.Self);
    }
}
