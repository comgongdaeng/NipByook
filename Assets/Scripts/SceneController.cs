﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static void GoLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public static void GoLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public static void GoLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public static void GoGameClear()
    {
        SceneManager.LoadScene("GameClear");
    }
}