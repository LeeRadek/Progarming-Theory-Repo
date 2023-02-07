using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField]
    GameObject canvasParent;
    [SerializeField]
    Slider slider;
    [SerializeField]
    Text text;
    [SerializeField]
    protected new string name;
    [SerializeField]
    public int maxHealth;
    public int minHealth { get; private set; }
    protected int Health;
    public int health { get; private set; }


    void Awake()
    {
        GetRef();
        SetName();
        HideLabel();
    }

    private void Start()
    {
        minHealth = 0;
        health = maxHealth;
        slider.minValue = 0;
        slider.maxValue = maxHealth;
        slider.value = health;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void GetRef()
    {
        canvasParent = transform.GetChild(0).gameObject;
        slider = canvasParent.GetComponentInChildren<Slider>();
        text = canvasParent.GetComponentInChildren<Text>();
        
    }

    protected void SetName()
    {
        if(name == null)
        {
            name = gameObject.name;
        }
        text.text = name;
    }

    public void ShowLabel()
    {
        
        canvasParent.transform.GetChild(0).gameObject.SetActive(!canvasParent.transform.GetChild(0).gameObject.activeSelf);
        
    }

    protected void HideLabel()
    {
        canvasParent.transform.GetChild(0).gameObject.SetActive(false);
    }
}
