using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZwyciestwoDopasowania : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public Transform objects;
    public event EventHandler OnWin;

    private void Start()
    {
        pointsToWin = objects.childCount;
    }

    public void AddPoints()
    {
        currentPoints++;
        if (currentPoints >= pointsToWin)
        {
            OnWin?.Invoke(this, EventArgs.Empty);
        }
    }
}
