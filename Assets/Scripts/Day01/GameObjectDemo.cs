using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDemo : MonoBehaviour
{
    private void OnGUI()
    {
        //实际激活状态
        //this.gameObject.activeInHierarchy;
        //自身激活状态
        //this.gameObject.activeSelf;
        //设置物体启用/禁用
        //this.gameObject.SetActive();

        //禁用
        //Light light = new Light();
        //可行
        //this.gameObject.AddComponent<Light>();

        if (GUILayout.Button("添加光源"))
        {
            //创建物体
            GameObject lightGO = new GameObject();
            //添加组件
            Light light = lightGO.AddComponent<Light>();
            //添加红色点光源
            light.color = Color.red;
            light.type = LightType.Point;
        }

        //在场景中根据名称查找物体(慎用)
        //GameObject.Find("游戏对象名称")

        GameObject[] allEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject playerGO = GameObject.FindWithTag("Player");

        //根据类型查找对象
        //Object.FindObjectsOfType<MeshRenderer>();
        //FindObjectsOfType<MeshRenderer>;

        //Object.Destroy;
    }
}