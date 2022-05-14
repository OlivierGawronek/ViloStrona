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

    public static GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player") && GameManager.Oceny >= minOcen && GameManager.Oceny <= maxOcen)
        {
            player = GameObject.Find("Gracz");
            player.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f);
            player.SetActive(false);
            SceneManager.LoadScene(sceneToLoad.ToString());
        }
    }
}

   
