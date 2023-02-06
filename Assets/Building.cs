using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField]
    Canvas canvas;
    [SerializeField]
    Slider slider;
    [SerializeField]
    Text text;
    [SerializeField]
    protected new string name;
    
    int maxHealth;
    int minHealth;
    int health;

    void Awake()
    {
        GetRef();
        SetName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetRef()
    {
        canvas = GetComponentInChildren<Canvas>();
        
    }

    protected void SetName()
    {

        text.text = name;
    }

    public void ShowLabel()
    {
        
        canvas.transform.GetChild(0).gameObject.SetActive(!canvas.transform.GetChild(0).gameObject.activeSelf);
        
    }
}
