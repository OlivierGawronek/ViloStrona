using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nauczyciel : MonoBehaviour
{
    private DialogueTrigger dialogueTrigger;
    private bool wasTriggered;

    [SerializeField] int minDial;
    [SerializeField] int maxDial;

    public Animator Camera;

    private void Awake()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
        wasTriggered = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player") && !wasTriggered && GameManager.dInt >= minDial && GameManager.dInt <= maxDial)
        {
            if (GameManager.dInt == 0) Camera.SetBool("IsShaking", true);
            
            dialogueTrigger.TriggerDialogue();
            Player player = collision.GetComponent<Player>();
            player.canMove = false;
            wasTriggered = true;
            GameManager.dInt++;
            //Destroy(gameObject);
        }
    }
}
