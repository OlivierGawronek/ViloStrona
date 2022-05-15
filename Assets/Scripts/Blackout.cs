using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackout : MonoBehaviour
{
    public static bool blackout;

    [SerializeField]
    private GameObject blackoutobj;

    [SerializeField]
    private GameObject player;

    private void Start()
    {
        blackout = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(blackout == true && player.transform.position.y > -2.250147 && player.transform.position.y < 0.472082f)
        {
            blackoutobj.SetActive(true);
        }
        else
        {
            blackoutobj.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        blackout = !blackout;
    }
}
