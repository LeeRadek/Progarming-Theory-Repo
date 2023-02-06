using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bilboard : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        RotateToCamera();
    }

    void RotateToCamera()
    {
        transform.LookAt(transform.position + Camera.main.transform.forward);
    }
}
