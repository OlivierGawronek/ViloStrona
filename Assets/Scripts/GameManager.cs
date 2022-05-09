using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool Licz = false;
    [SerializeField]
    private GameObject Canv;

    [SerializeField]
    GameObject player;

    public Vector2 playerPosition;

    public static int Oceny;

    private void Awake()
    {
        
    }

    private void Update()
    {
        if(Licz.Equals(true))
        Canv.transform.gameObject.SetActive(true);
        Debug.Log(Oceny);

    }

    public void StartGameBtn()
    {
        SceneManager.LoadScene(Teleport.Scene.KorytarzScene.ToString());
        Licz = true;
    }
}
