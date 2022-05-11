using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text Timertxt;

    [SerializeField]
    private Text PktTxt;

    public static float Timeint;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Update()
    {
        Timers();
        Oceny();
    }

    void Timers()
    {
        Timeint += Time.deltaTime;
        int min = (int)(Timeint / 60f);
        float sec = Timeint % 60F;
        Timertxt.text = "Czas:" + min.ToString("00") + ":" + sec.ToString("00");
    }

    void Oceny()
    {
        PktTxt.text = "ILOSC OCEN: " + GameManager.Oceny.ToString("0");
    }
}
