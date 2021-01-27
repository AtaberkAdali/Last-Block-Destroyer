using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_block2 : MonoBehaviour
{
    private int can;
    private int vurulmaSayisi;
    public Sprite[] blockGörünümleri;
    public AI_top2 otoSure;
    public GameObject effeckt;
    [SerializeField] GameObject losePanel;
    private static int blok_sayisi;
    void Start()
    {
        blok_sayisi = 0;
        otoSure = GameObject.FindObjectOfType<AI_top2>();
        vurulmaSayisi = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        can = blockGörünümleri.Length + 1;
        vurulmaSayisi++;
        if (vurulmaSayisi >= can)
        {
            blok_sayisi++;
            GetComponent<AudioSource>().Play();
            effecktim();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            GetComponent<AudioSource>().Play();
            BlockGoruntusunuDegisitir();
        }

        if (blok_sayisi == 18 )
        {
            Debug.Log("t=" + otoSure.time_current + "  x=" + otoSure.barin_xiiii);
            Debug.Log("AI kazandı.");
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    void effecktim()
    {
        GameObject efektim = Instantiate(effeckt, gameObject.transform.position, Quaternion.identity) as GameObject;
        efektim.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
    }
    public void BlockGoruntusunuDegisitir()
    {
        this.GetComponent<SpriteRenderer>().sprite = blockGörünümleri[vurulmaSayisi - 1];
    }
}
