﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    public void StartLevel(int level)
    {
        SceneLoader.LoadLevel(level);
    }
}
