using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentDemo : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUILayout.Button("按钮"))
        {
            Debug.Log("ok");
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}