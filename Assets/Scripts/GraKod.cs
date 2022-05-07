using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GraKod : MonoBehaviour
{
    [SerializeField] private Transform winScreen;

    private void Start()
    {
        ZwyciestwoDopasowania zwyciestwoDopasowania = transform.GetComponent<ZwyciestwoDopasowania>();
        zwyciestwoDopasowania.OnWin += Win;
        winScreen.gameObject.SetActive(false);
    }

    public void BackToKorytarz()
    {
        SceneManager.LoadScene(Teleport.Scene.KorytarzScene.ToString());
    }

    private void Win(object sender, EventArgs e)
    {
        winScreen.gameObject.SetActive(true);
        GameManager.Oceny += 1;
    }
}
