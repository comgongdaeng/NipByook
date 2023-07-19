﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void GoLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void GoLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void GoGameClear()
    {
        SceneManager.LoadScene("GameClear");
    }
}