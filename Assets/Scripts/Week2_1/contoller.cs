using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contoller : MonoBehaviour
{
    public GameObject otherobject;
    // Update is called once per frame
    void Update()
    {
        move test = otherobject.GetComponent<move>();
        test.xmovetest();
    }
}
