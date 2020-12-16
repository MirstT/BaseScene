using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Week3_2 : MonoBehaviour
{
    public GameObject[] obj;
    private int counter = 0;
    public Text text;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (counter % 2 == 0)
            foreach (var item in obj)
                item.SetActive(true);
        else
            foreach (var item in obj)
                item.SetActive(false);

    }

    public void OnClick()
    {
        counter++;
    }
}