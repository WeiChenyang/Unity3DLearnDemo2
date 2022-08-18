using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    //当小球撞到障碍物
    private void OnCollisionEnter(Collision collision)
    {
        //让游戏停下来    游戏世界时间停止
        //Time.timeScale = 0;

        //使用GameObject.Find方法获取Unity界面SampleScene中已创建对象GM中属性GM脚本类中的GameOver方法
        GameObject.Find("GM").GetComponent<GM>().GameOver();
    }
}
