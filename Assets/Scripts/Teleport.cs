using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public enum Scene
    {
        KorytarzScene,
        InformatykaScene,
        PolskiScene,
        GeografiaScene,
        MatematykaScene,
        HistoriaScene
    }

    [SerializeField] Scene sceneToLoad;
    [SerializeField] int minOcen;
    [SerializeField] int maxOcen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player") && GameManager.Oceny >= minOcen && GameManager.Oceny <= maxOcen)
        {
            SceneManager.LoadScene(sceneToLoad.ToString());
            GameManager.Licz = false;
        }
        Debug.Log(sceneToLoad);
    }
}

   
