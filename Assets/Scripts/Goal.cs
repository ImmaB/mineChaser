﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {   
        if (col.gameObject.tag == "Player")
            SceneLoader.instance.LoadScene(0);
    }
}
