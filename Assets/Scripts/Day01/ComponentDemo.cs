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
            //子类，继承父类 Component的元素
            this.transform.position = new Vector3(0, 0, 10);
            this.GetComponent<MeshRenderer>().material.color = Color.red;
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