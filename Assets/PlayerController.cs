using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    [SerializeField]
    List<Building> buildings = new List<Building>();
    [SerializeField]
    List<Unit> units = new List<Unit>();

    

    void Start()
    {
        
    }

    
    void Update()
    {
        CheckObject();
        MoveTo();

    }

    void CheckObject()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                //print(hit.collider.gameObject.tag);
                if(hit.collider.GetComponent<Unit>() != null)
                {
                    buildings.Clear();
                    units.Add(hit.collider.GetComponent<Unit>());
                    hit.collider.GetComponent<Unit>().ShowLabel();
                }
                else if(hit.collider.GetComponent<Building>() != null)
                {
                    units.Clear();
                    buildings.Add(hit.collider.GetComponent<Building>());
                    hit.collider.GetComponent<Building>().ShowLabel();
                }

                if(hit.collider.gameObject.tag == "Ground")
                {
                    
                    ClearSlection();
                }
            }
            else
            {
                ClearSlection();
            }
        }
    }

    void ClearSlection()
    {
        buildings.Clear();
        units.Clear();
    }

    void MoveTo()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if(units.Count == 0)
                {
                    return;
                }
                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.green, 2);
                units[0].Move(hit.point);
            }
        }
    }
}
