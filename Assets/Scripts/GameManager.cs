using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool licz = false;
    public GameObject Canv;
    

    private void Update()
    {
        if(licz.Equals(true))
        Canv.transform.gameObject.SetActive(true);
    }

    public void StartGameBtn()
    {
        SceneManager.LoadScene(Teleport.Scene.KorytarzScene.ToString());
        licz = true;
    }
}
