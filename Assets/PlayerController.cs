using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        CheckObject();
    }

    void CheckObject()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                print(hit.collider.gameObject.name);
            }
        }
    }
}
