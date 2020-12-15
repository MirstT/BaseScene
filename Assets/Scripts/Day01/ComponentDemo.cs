using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Component类提供了查找（在当前物体，后代，先辈）组件的功能
/// </summary>
public class ComponentDemo : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUILayout.Button("transform"))
        {
            Debug.Log("ok");
            //子类，继承父类 Component的元素
            this.transform.position = new Vector3(0, 0, 10);
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (GUILayout.Button("GetComponent"))
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (GUILayout.Button("GetComponents"))
        {
            var allComponent = this.GetComponents<Component>();
            foreach (var item in allComponent)
            {
                print(item.GetType());
            }
        }
        if (GUILayout.Button("GetComponentsInChildren"))
        {
            //获取后代物体的指定类型组件（从自身开始）
            var allComponentOfChildren = this.GetComponentsInChildren<MeshRenderer>();
            foreach (var item in allComponentOfChildren)
            {
                item.material.color = Color.blue;
            }
        }
        if (GUILayout.Button("GetComponentsInParent"))
        {
            //获取先辈物体的指定类型组件（从自身开始）
            var allComponentOfParent = this.GetComponentsInParent<MeshRenderer>();
            foreach (var item in allComponentOfParent)
            {
                item.material.color = Color.blue;
            }
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