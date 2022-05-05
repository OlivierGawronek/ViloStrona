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
        MatematykaScene
    }

    [SerializeField] Scene sceneToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.licz = false;
        if (collision.tag.Equals("Player"))
        {
            SceneManager.LoadScene(sceneToLoad.ToString());
        }
    }
}
