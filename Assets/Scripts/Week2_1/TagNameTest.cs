using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagNameTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj1 = GameObject.Find("Cube");
        obj1.transform.Rotate(1, 0, 0);
        GameObject obj2 = GameObject.FindWithTag("Cap");
        obj2.transform.Rotate(1, 0, 0);
    }
}
