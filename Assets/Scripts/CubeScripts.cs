using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right*Time.deltaTime*10);
        }
        // if(Input.
        // if(Input.GetKey(KeyCode.UpArrow))
        // {
        //     transform.Rotate
        // }
    }

    // void FixedUpdate() {
    //     Debug.Log("i am FixedUpdate");
    // }

    // void LateUpdate() {
    //     .Debug.Log("i am LateUpdate");
    // }
    // void private void LateUpdate() {
    //     if (true)
    //     {
    //         this.transform.Rotate(Vector3.right)
    //     }
    // }
}
