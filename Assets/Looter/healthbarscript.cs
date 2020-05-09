using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarscript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public Stats stats;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void Start()
    {
        SetMaxHealth(stats.HP);
    }

    private void Update()
    {
        SetHealth(stats.HP);
    }
}
