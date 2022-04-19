using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Timertxt;
    public float Timeint;
    

    void Update()
    {
        Timer();
    }

    void Timer()
    {
        Timeint += Time.deltaTime;
        float min = Timeint / 60f;
        float sec = Timeint % 60F;
        Timertxt.text = "Czas:" +  min.ToString("0") + ":" + sec.ToString("0");
    }
}
