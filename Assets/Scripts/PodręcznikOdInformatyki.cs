using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PodręcznikOdInformatyki : MonoBehaviour
{
    [SerializeField] private Text text;
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
            GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(Znaleziono());
        }   
    }

    private IEnumerator Znaleziono()
    {
        text.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        text.gameObject.SetActive(false);
        GameManager.Oceny += 1;
    }
}
