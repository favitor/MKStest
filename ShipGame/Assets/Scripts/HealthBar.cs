using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider Slider;
    public Vector3 offSet;

    public void SetHealth(int health, int maxHealth)
    {
        Slider.gameObject.SetActive(true);
        Slider.value = health;
        Slider.maxValue = maxHealth;
        
    }

    void Update()
    {
        Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offSet);
        
    }
}
