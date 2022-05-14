using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nauczyciel : MonoBehaviour
{
    private DialogueTrigger dialogueTrigger;
    private bool wasTriggered;

    private void Awake()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
        wasTriggered = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !wasTriggered)
        {
            dialogueTrigger.TriggerDialogue();
            Player player = collision.GetComponent<Player>();
            player.canMove = false;
            wasTriggered = true;
        }
    }
}
