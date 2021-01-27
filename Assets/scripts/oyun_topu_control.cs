using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyun_topu_control : MonoBehaviour
{
    private static float barin_xi;
    public oyun_bari_control oyun_barii;
    private bool basladiMi;
    private Vector3 topIleBarArasıMesafe;
    [SerializeField] float hızX;
    [SerializeField] float hızY;
    [SerializeField] int yon_degistir;
    private oyun_bari_control barim;
    private sahne_control sahne_management;//
    [SerializeField] Text directionn;
    [SerializeField] Text timee;
    private float time_current=0;
    void Start()
    {
        directionn.text = yon_degistir.ToString();
        Time.timeScale = 1;
        sahne_management = GameObject.FindObjectOfType<sahne_control>();
        topIleBarArasıMesafe = this.transform.position - oyun_barii.transform.position;
        barim = GameObject.FindObjectOfType<oyun_bari_control>();
        if (barim.otomatik_oyna)
        {
            barin_xi = Random.Range(1f, 31f);
            this.transform.position = new Vector3(barin_xi, transform.position.y, transform.position.z);
            ilkAtıs();
            Time.timeScale = 5;
        }
        //Debug.Log("x = " + barin_xi);
    }

    // Update is called once per frame
    void Update()
    {
        if (!basladiMi)
        {
            this.transform.position = oyun_barii.transform.position + topIleBarArasıMesafe;
        }
        else
        {
            time_current += Time.deltaTime;
            timee.text = ((int)time_current).ToString();
        }
        if (yon_degistir > 0)
        {
            if (Input.GetMouseButtonDown(1))
            {
                ilkAtıs();
            }
            if (Input.GetMouseButtonDown(0))
            {
                directionn.text = (yon_degistir-1).ToString();
                yon_degistir--;
                basladiMi = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector3(-hızX, hızY, 0f);
            }
        }
    }
    void ilkAtıs()
    {
        directionn.text = (yon_degistir-1).ToString();
        yon_degistir--;
        basladiMi = true;
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(hızX, hızY, 0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 ufakSapma = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));
        if (basladiMi)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity += ufakSapma;
        }
    }
}
