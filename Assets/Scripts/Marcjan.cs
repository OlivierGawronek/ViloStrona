using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marcjan : Nauczyciel
{



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && GameManager.dInt >= minDial && GameManager.dInt <= maxDial && GameManager.Oceny >= minOcen && GameManager.Oceny <= maxOcen)
        {
            dialogueTrigger.TriggerDialogue();
            Player player = collision.GetComponent<Player>();
            player.canMove = false;
        }
    }
}
