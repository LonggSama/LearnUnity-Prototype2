using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungryBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHungry (int hungry)
    {
        slider.maxValue = hungry;
    }

    public void SetHungry (int hungry)
    {
        slider.value = hungry;
    }
}
