using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//视角跟着小球走 例如放风筝
public class Follow : MonoBehaviour
{
    public Transform t;//声明 定义一个人 在unity 界面 Follow 脚本属性中对t对象进行实体化
    Vector3 o;//定义了一条风筝线
    // Start is called before the first frame update
    void Start()
    {
        //在游戏刚开始的时候确定好风筝线的长度、角度等信息
        o = transform.position - t.position;
    }

    // Update is called once per frame
    void Update()
    {
        //让每时每刻风筝都被人和线拖着走
        transform.position = t.position + o;

        float h = Input.GetAxis("Horizontal");



    }
}
