using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI_top : MonoBehaviour
{
    private static float barin_xi;
    public AI_bar oyun_barii;
    private Vector3 topIleBarArasıMesafe;
    [SerializeField] float hızX;
    [SerializeField] float hızY;
    private player_top playerinTop;
    private bool baslamis = false;
    private bool oneTime = true;
    [SerializeField] Text timee;
    public float time_current = 0;
    private sahne_control sahne_management;
    void Start()
    {
        sahne_management = GameObject.FindObjectOfType<sahne_control>();
        playerinTop = GameObject.FindObjectOfType<player_top>();
    }

    void Update()
    {
        baslamis = playerinTop.basladiMi;
        if (baslamis)
        {
            time_current += Time.deltaTime;
            timee.text = ((int)time_current).ToString();
            if (oneTime)
            {
                topIleBarArasıMesafe = this.transform.position - oyun_barii.transform.position;
                barin_xi = Random.Range(17.7f, 31f);
                this.transform.position = new Vector3(barin_xi, transform.position.y, transform.position.z);
                ilkAtıs();
                Debug.Log("x = " + barin_xi);
                oneTime = false;
            }
        }
    }
    void ilkAtıs()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(hızX, hızY, 0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 ufakSapma = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));
        GetComponent<AudioSource>().Play();
        GetComponent<Rigidbody2D>().velocity += ufakSapma;
    }
}
