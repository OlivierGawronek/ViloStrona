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
        player = GameObject.Find("Gracz");
        if(blackout == true && player.transform.position.y > -2.158f && player.transform.position.y < 0.586f)
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
