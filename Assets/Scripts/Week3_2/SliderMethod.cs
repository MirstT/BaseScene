using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMethod : MonoBehaviour
{
    public Slider sd;
    public Text text;

    public void OnValuechanged()
    {
        text.text = "当前的值为" + sd.value;
    }
}