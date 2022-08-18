using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    //当小球进入终点体内时
    private void OnTriggerEnter(Collider other)
    {
        //使用GameObject.Find方法获取Unity界面SampleScene中已创建对象GM中属性GM脚本类中的GamePass方法
        GameObject.Find("GM").GetComponent<GM>().GamePass();
    }
}
