﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Singleton

    private static UIManager s_instance = null;

    public static UIManager Instance { get { return s_instance; } }

    #endregion

    [SerializeField]
    private EndGameScreen EndGameScreen = null;


    private void Awake()
    {
        s_instance = this;
    }

    public void ShowMessageOnHUD(Transform worldOrigin, string message) { }

    public void ShowEndGameScreen(ref List<Transaction> receipt, string grade)
    {
        EndGameScreen.ShowEndGameScore(ref receipt, ref grade);
    }
}
