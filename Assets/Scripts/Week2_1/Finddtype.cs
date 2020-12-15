using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finddtype : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test test = FindObjectOfType<Test>();
        Debug.Log(test.gameObject.name);

        Test[] tests = FindObjectsOfType<Test>();
        foreach(Test te in tests)
        {
            Debug.Log(te.gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
