using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int health) //affiche la vie max sur l'ui
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health) //affiche la vie actuelle du player
    {
        slider.value = health;
    }

}
