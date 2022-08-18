using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody r;//声明刚体对象   刚体可以模拟现实中物体的运动，具有速度
    public float speed = 10;//速度 默认10
    float p = 1.5f;
    float l = 0;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();//获取刚体对象组件
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");//获取方向键左右输入值
        float z = Input.GetAxis("Vertical");//获取方向键上下
        if (z > 0)
        {
            speed = speed + 3;
        }
        else if (z < 0)
        {
            speed = speed <= 0? 0:(speed - 3);
        }
        else {
            speed = 6;
        }

        r.velocity = new Vector3(x*8,r.velocity.y,speed);//速度 x,y,z 
        if (Time.time >= l+p) {
            Vector3 f = new Vector3(0,5,0);
            r.AddForce(f,ForceMode.Impulse);//给小球施加力f
            l = Time.time;
        }
    }
}
