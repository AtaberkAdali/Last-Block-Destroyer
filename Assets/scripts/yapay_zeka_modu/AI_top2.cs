using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI_top2 : MonoBehaviour
{
    private static float barin_xi;
    public float barin_xiiii;
    public AI_bar2 oyun_barii;
    private Vector3 topIleBarArasıMesafe;
    [SerializeField] float hızX;
    [SerializeField] float hızY;
    private player_top playerinTop;
    private bool baslamis = false;
    private bool oneTime = true;
    [SerializeField] Text timee;
    public float time_current = 0;
    private float[] ximizz;
    private int rasgele;
    void Start()
    {
        ximizz = new float[8];
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
            rasgelelik();
            topIleBarArasıMesafe = this.transform.position - oyun_barii.transform.position;
            barin_xi = ximizz[rasgele];
            this.transform.position = new Vector3(barin_xi, transform.position.y, transform.position.z);
            ilkAtıs();
            barin_xiiii = barin_xi;
            oneTime = false;
        }
        }
    }

    void rasgelelik()
    {
        ximizz[1] = 23.74626f;
        ximizz[2] = 18.58912f;
        ximizz[3] = 29.73389f;
        ximizz[4] = 28.90143f;
        ximizz[5] = 18.58387f;
        ximizz[0] = 27.93763f;
        rasgele = Random.Range(0, 6);
    }
    void ilkAtıs()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(hızX, hızY, 0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
