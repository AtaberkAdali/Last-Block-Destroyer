using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaybettin : MonoBehaviour
{
    [SerializeField] GameObject LosePanel;
    [SerializeField] GameObject directionnn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        LosePanel.SetActive(true);
        directionnn.SetActive(false);
        Debug.Log("kaybetti.");
        Time.timeScale = 0;
    }
}
