using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    
    Slider slider;
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
        slider = GetComponentInChildren<Slider>();
        text = GetComponentInChildren<Text>();
    }

    void SetName()
    {

        text.text = name;
    }
}
