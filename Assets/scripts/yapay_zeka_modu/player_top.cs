using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_top : MonoBehaviour
{
    public player_bar oyun_barii;
    public bool basladiMi = false;
    private Vector3 topIleBarArasıMesafe;
    [SerializeField] float hızX;
    [SerializeField] float hızY;
    [SerializeField] int yon_degistir=3;
    [SerializeField] Text directionn;
    void Start()
    {
        Time.timeScale = 1;
        topIleBarArasıMesafe = this.transform.position - oyun_barii.transform.position;
        directionn.text = yon_degistir.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (!basladiMi)
        {
            this.transform.position = oyun_barii.transform.position + topIleBarArasıMesafe;
        }
        if (yon_degistir > 0)
        {
            if (Input.GetMouseButtonDown(1))
            {
                directionn.text = (yon_degistir - 1).ToString();
                yon_degistir--;
                basladiMi = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector3(hızX, hızY, 0f);
            }
            if (Input.GetMouseButtonDown(0))
            {
                directionn.text = (yon_degistir - 1).ToString();
                yon_degistir--;
                basladiMi = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector3(-hızX, hızY, 0f);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 ufakSapma = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
        if (basladiMi)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity += ufakSapma;
        }
    }
}
