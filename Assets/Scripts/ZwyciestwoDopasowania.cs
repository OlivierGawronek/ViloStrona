using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZwyciestwoDopasowania : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public Transform objects;

    private void Start()
    {
        pointsToWin = objects.childCount;
    }

    private void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            Debug.Log("Wygrana!");
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
