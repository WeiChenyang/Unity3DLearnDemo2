using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//引入Unity 界面 SampleScene 管理
using UnityEngine.UI;//对界面操作 引入UI

public class GM : MonoBehaviour
{
    //物体对应声明 可在Untiy界面 GM 脚本 属性中配置指定Panel对象实体化
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        //panel物体隐藏
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //自定义游戏结束方法
    public void GameOver() {
        //让游戏停下来    游戏世界时间停止
        Time.timeScale = 0;
        //panel物体显示
        panel.SetActive(true);
        //修改界面提示文字
        Text t = panel.transform.Find("Text").GetComponent<Text>();
        t.text = "Game Over!";
    }

    //自定义游戏重新开始方法
    public void GameRestart() {
        //游戏世界时间重新开始
        Time.timeScale = 1;
        //重新开始
        SceneManager.LoadScene(0);
    }

    //游戏过关
    public void GamePass() {
        //让游戏停下来    游戏世界时间停止
        Time.timeScale = 0;
        //panel物体显示
        panel.SetActive(true);
        //修改界面提示文字
        Text t = panel.transform.Find("Text").GetComponent<Text>();
        t.text = "通关!";
    }
}
