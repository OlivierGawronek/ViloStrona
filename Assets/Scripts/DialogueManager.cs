using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    public Animator Camera;

    private GameObject CamObjl;


    [SerializeField]
    private GameObject UI;

    public Image image;

    private Queue<string> sentences;

    private void Awake()
    {
        sentences = new Queue<string>();
        Camera = CamObjl.GetComponent<Animator>();
    }


    public void StartDialogue(Dialogue dialogue)
    {
        CamObjl = GameObject.Find("MainCamera");
        UI.SetActive(true);
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;
        image.sprite = dialogue.image;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    private void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        Player player = FindObjectOfType<Player>();
        player.canMove = true;
        UI.SetActive(false);
        Camera.SetBool("IsShaking", false);
        Camera.enabled = false;

        if (GameManager.Oceny == 5)
        {
            SceneManager.LoadScene("Wygrana");
            Time.timeScale = 0;

        }
    }
}
