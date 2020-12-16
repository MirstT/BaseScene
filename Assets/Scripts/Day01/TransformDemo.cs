using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Transform类提供了 查找变换组件（父，根，子）,改变位置，角度，大小功能
/// </summary>
public class TransformDemo : MonoBehaviour
{
    public Transform tf;

    private void OnGUI()
    {
        if (GUILayout.Button("foreach--transform"))
        {
            foreach (Transform child in this.transform)
            {
                print(child.name);
            }
        }
        if (GUILayout.Button("foreach--position&localPosition"))
        {
            foreach (Transform child in this.transform)
            {
                //物体相对于世界坐标系原点的位置
                print("world" + child.position);
                //物体相对于父物体轴心点的位置
                print("local" + child.localPosition);

                //loca均是相对于父物体
                //this.transform.localRotation;
                //this.transform.localScale;
                //只读
                //this.transform.lossyScale
            }
        }
        if (GUILayout.Button("Translate"))
        {
            foreach (Transform child in this.transform)
            {
                //向自身坐标系z轴移动1m
                //this.transform.Translate(0, 0, 1);
                //向世界坐标系z轴移动1m
                this.transform.Translate(0, 0, 1, Space.World);
            }
        }

        //RepeatButton
        if (GUILayout.RepeatButton("RotateAround"))
        {
            foreach (Transform child in this.transform)
            {
                //围绕旋转
                this.transform.RotateAround(Vector3.zero, Vector3.forward, 1);
            }
        }

        if (GUILayout.Button("Rotate"))
        {
            foreach (Transform child in this.transform)
            {
                //向自身坐标系y轴
                //this.transform.Rotate(0, 10, 0);
                //向世界坐标系y轴
                this.transform.Rotate(0, 10, 0, Space.World);
            }
        }

        if (GUILayout.Button("root/parent"))
        {
            //获取根物体变换组件
            Transform rootTF = this.transform.root;
            //获取父物体变换组件
            Transform parentTF = this.transform.parent;
        }

        if (GUILayout.Button("set root/parent"))
        {
            this.transform.SetParent(tf);
        }
        if (GUILayout.Button("set root/parent notworld"))
        {
            this.transform.SetParent(tf, false);
        }

        if (GUILayout.Button("Find( / / / )"))
        {
            //根据名称获取子物体
            Transform childTF = this.transform.Find("子物体名称/下一级/下一级");
        }

        Transform[] childTFArray = new Transform[100];

        if (GUILayout.Button("by 索引"))
        {
            //还是只能子物体
            int count = this.transform.childCount;
            for (int i = 0; i < count; i++)
            {
                childTFArray[i] = this.transform.GetChild(i);
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