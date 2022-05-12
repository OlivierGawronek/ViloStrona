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


    public Vector2 playerPosition;

    public static int Oceny;

    private void Awake()
    {
        
    }

    private void Update()
    {
        if(Licz.Equals(true) && Canv != null)
        Canv.transform.gameObject.SetActive(true);

        //if (Input.GetKeyDown(KeyCode.R)) Oceny = 4;

        if(Oceny == 4)
        {
            SceneManager.LoadScene("Wygrana");
            Time.timeScale = 0;
        }


        

    }

    public void StartGameBtn()
    {
        SceneManager.LoadScene(Teleport.Scene.KorytarzScene.ToString());
        Licz = true;
    }
}
