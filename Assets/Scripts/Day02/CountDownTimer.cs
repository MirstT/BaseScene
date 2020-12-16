using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 倒计时
/// </summary>
public class CountDownTimer : MonoBehaviour
{
    //1.查找组件引用
    //2.定义变量：秒second
    //3.时间转换
    //4.修改文本
    private Text txtTimer;

    public int second = 120;

    private void Start()
    {
        txtTimer = this.GetComponent<Text>();
        //启动调用
        InvokeRepeating("Timer03", 0, 1);
    }

    public float nextTime = 1;//下次修改时间

    private void Update()
    {
        //Timer01();
        //Timer02();
    }

    //1:Time.time
    private void Timer01()
    {
        if (Time.time >= nextTime)
        {
            second--;
            txtTimer.text = string.Format("{0:d2}:{1:d2}", second / 60, second % 60);
            if (second <= 10)
            {
                txtTimer.color = Color.red;
            }
            //nextTime = Time.time + 1;
            nextTime += 1;
        }
    }

    //2:Time.deltaTime
    private float totalTime;

    private void Timer02()
    {
        totalTime += Time.deltaTime;
        if (totalTime >= 1)
        {
            second--;
            txtTimer.text = string.Format("{0:d2}:{1:d2}", second / 60, second % 60);
            totalTime = 0;
        }
    }

    //3:Invoke()
    //每隔固定时间重复执行
    private void Timer03()
    {
        second--;
        txtTimer.text = string.Format("{0:d2}:{1:d2}", second / 60, second % 60);

        if (second <= 0)
        {
            //取消调用
            CancelInvoke("Timer03");
        }
    }

    //5.如何每秒修改一次
    //重点：在Update每帧执行的方法中，个别语句实现指定间隔执行一次.
    //Time.time
}