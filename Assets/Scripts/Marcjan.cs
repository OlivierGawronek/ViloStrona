using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcjan : Nauczyciel
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !wasTriggered && GameManager.dInt >= minDial && GameManager.dInt <= maxDial && GameManager.Oceny >= minOcen && GameManager.Oceny <= maxOcen)
        {
            dialogueTrigger.TriggerDialogue();
            Player player = collision.GetComponent<Player>();
            Player.canMove = false;
            wasTriggered = true;
            //Destroy(gameObject);
        }
    }
}
