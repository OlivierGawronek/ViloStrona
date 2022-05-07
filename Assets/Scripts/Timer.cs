using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text Timertxt;
    private float Timeint;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Update()
    {
        Timers();
    }

    void Timers()
    {
        Timeint += Time.deltaTime;
        float min = Timeint / 60f;
        float sec = Timeint % 60F;
        Timertxt.text = "Czas:" + min.ToString("0") + ":" + sec.ToString("0");
    }
}
