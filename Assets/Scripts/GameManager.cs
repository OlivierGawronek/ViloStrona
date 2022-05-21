using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;


    [SerializeField]
    private GameObject Canv;

    


    public Vector2 playerPosition;

    public static int dInt;
    public static int Oceny;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R)) Oceny = 4;

        


    }

    public void StartGameBtn()
    {
        SceneManager.LoadScene(Teleport.Scene.KorytarzScene.ToString());
    }
}
