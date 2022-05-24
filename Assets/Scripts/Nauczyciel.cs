using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nauczyciel : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;
    public bool wasTriggered;

    public int minDial;
    public int maxDial;
    public int minOcen;
    public int maxOcen;

    [SerializeField] GameObject player;

    public Animator Camera;

    private void Awake()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
        wasTriggered = false;
    }

    private void Update()
    {
        player = GameObject.Find("Gracz");


        if (player != null)
        {
            if (gameObject.transform.position.x > player.transform.position.x)
            {
                transform.localScale = new Vector2(-1.2f, 1.2f);
            }
            else if (gameObject.transform.position.x < player.transform.position.x)
            {
                transform.localScale = new Vector2(1.2f, 1.2f);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player") && !wasTriggered && GameManager.dInt >= minDial && GameManager.dInt <= maxDial && GameManager.Oceny >= minOcen && GameManager.Oceny <= maxOcen)
        {
            if (GameManager.dInt == 0)
            {
                Camera.SetBool("IsShaking", true);
                Camera.enabled = true;
            }
                
                
            
            dialogueTrigger.TriggerDialogue();
            Player player = collision.GetComponent<Player>();
            player.canMove = false;
            wasTriggered = true;
            GameManager.dInt++;
            //Destroy(gameObject);
        }
    }
}
