﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void Change(string escena)
    {
        SceneManager.LoadScene(escena);
        Time.timeScale = 1f;
    }
}
