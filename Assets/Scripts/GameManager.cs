using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject Car;
    GameObject Flag;
    GameObject Distance;
    GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        Car = GameObject.Find("car");
        Flag = GameObject.Find("flag");
        Distance = GameObject.Find("Distance");
        Score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        float Length = Flag.transform.position.x - Car.transform.position.x;
        Distance.GetComponent<Text>().text = "距離目標還有：" + Length.ToString("F2") + "公尺";
        float Score2 = 0;
        if (Length < 0 || Length>=14.5f)
        {
            Score2 = 0;
        }
        else
        {
            Score2 = 100/Length;
            if (Score2 > 100)//分數大於100以100記
                Score2 = 100;
        }

        
        Score.GetComponent<Text>().text = "分數:" + Score2.ToString("F1") + "分";

    }

}
