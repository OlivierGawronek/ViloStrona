using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodręcznikOdInformatyki : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.Oceny != 1)
        {
            Destroy(gameObject);
        }       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.Oceny == 1)
        {
            GameManager.Oceny += 1;
        }   
    }
}
