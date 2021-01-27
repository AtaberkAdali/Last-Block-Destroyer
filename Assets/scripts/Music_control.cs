using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_control : MonoBehaviour
{
    static Music_control TekMusic= null;
    void Start()
    {
        if (TekMusic != null)
        {
            Destroy(gameObject);
        }
        else
        {
            TekMusic = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

}
