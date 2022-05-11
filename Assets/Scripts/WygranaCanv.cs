using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WygranaCanv : MonoBehaviour
{

    [SerializeField]
    private Text Wintxt;

    // Start is called before the first frame update
    void Start()
    {
        WygranaTime();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void WygranaTime()
    {
        float timestop = Timer.Timeint;
        int min = (int)(timestop / 60f);
        float sec = timestop % 60F;
        Wintxt.text = min.ToString("00") + ":" + sec.ToString("00");
    }
}
