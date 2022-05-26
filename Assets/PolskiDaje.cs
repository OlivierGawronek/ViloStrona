using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolskiDaje : MonoBehaviour
{
    public GameObject polski;
    void Update()
    {
        if(GameManager.dInt > 3)
        polski.GetComponent<BoxCollider2D>().enabled = true;
    }

    
}
