using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDemo : MonoBehaviour
{
    public float time;
    public float speed = 100;
    public float deltaTimea, unscaledDeltaTimeb, realtimeSinceStartupc, unscaledTimed;

    public void Update()
    {
        time = Time.time;//受缩放影响的游戏运行时间
        deltaTimea = Time.deltaTime;
        unscaledDeltaTimeb = Time.unscaledDeltaTime;//不受缩放影响的游戏运行时间
        realtimeSinceStartupc = Time.realtimeSinceStartup;//游戏实际运行时间
        unscaledTimed = Time.unscaledTime;
        //this.transform.Rotate(0, speed * Time.deltaTime, 0);

        //游戏暂停，个别物体不受影响  Time.unscaledDeltaTime不受缩放影响的每帧间隔
        this.transform.Rotate(0, speed * Time.unscaledDeltaTime, 0);
    }

    //0.02s
    public void FixedUpdate()
    {
        this.transform.Rotate(speed, 0, 0);
    }

    //游戏暂停
    //timeScale仅仅对时间造成影响 FixedUpdate deltaTime 并不会对Update造成影响
    private void OnGUI()
    {
        if (GUILayout.Button("暂停游戏"))
        {
            Time.timeScale = 0;
        }
        if (GUILayout.Button("继续游戏"))
        {
            Time.timeScale = 1;
        }
        if (GUILayout.Button("加速游戏"))
        {
            Time.timeScale = 3;
        }
    }
}