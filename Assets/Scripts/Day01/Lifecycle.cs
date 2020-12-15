using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 脚本生命周期/必然事件/消息 Message
/// </summary>
public class Lifecycle : MonoBehaviour
{
    //c#类:
    //字段 属性 构造函数 方法

    //脚本： 附加到游戏物体中，定义游戏对象行为指令的代码
    //字段 方法

    //字段
    public int testNum = 100;

    //序列化字段 作用:在编辑器中显示私有变量
    [SerializeField]
    private int testSerializeNum = 200;

    //在编译器中隐藏字段
    [HideInInspector]
    public int testHideNum = 300;

    [Range(0, 100)]
    public int testRangeNum = 400;

    //属性：在编译器中不能显示，通常脚本中不写
    public int A
    {
        get
        {
            return this.A;
        }
        set
        {
            this.A = value;
        }
    }

    private float time;
    public Lifecycle()
    {
        //不要在脚本中写构造函数
        Debug.Log("构造函数");
        //不能在子线程中访问主线程成员：
        //time = Time.time;
        //Debug.Log(time);
    }

    //private int testInit = Random.Range(1, 101);

    //*******************************初始阶段****************************
    //执行时机：创建游戏对象-->立即执行
    //作用:初始化
    private void Awake()
    {
        Debug.Log("Awake--" + Time.time + "--" + this.name);
    }
    //执行时机：创建游戏对象-->脚本启用-->才执行
    //作用:初始化
    private void Start()
    {
        int a = 1;
        int b = 2;
        int c = a + b;
        //右键-快速监视  查看-即时窗口

        Debug.Log("Start--" + Time.time + "--" + this.name);
        int testInit = Random.Range(1, 101);
        Debug.Log("testInit" + testInit);
        print("printOK");
    }

    //*******************************物理阶段****************************
    //执行时机：每隔固定时间执行1次（时间可以修改）
    //适用性：适合对物体做物理操作（移动，旋转.......），不会受到渲染影响
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");

    }

    //执行时机：渲染帧执行，执行间隔不固定
    //适用性：处理游戏逻辑
    public float testShowTime;
    private void Update()
    {//渲染时间不固定（每帧渲染量不同，机器性能不同）
        testShowTime = Time.time;

        //单帧调试：启动调试 运行场景 暂停游戏 加断点 单帧执行 结束调试
        int a = 1;
        int b = 2;
        int c = a + b;
        //右键-快速监视  查看-即时窗口

    }

}
