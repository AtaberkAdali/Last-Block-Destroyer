using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_control1 : MonoBehaviour
{
    private int can;
    private int vurulmaSayisi;
    public Sprite[] blockGörünümleri;
    private static int totalBlockNumber=0;
    public GameObject effeckt;
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject directionnn;
    // Start is called before the first frame update
    void Start()
    {
        vurulmaSayisi = 0;
        totalBlockNumber = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        can = blockGörünümleri.Length + 1;
        vurulmaSayisi++;
        if (vurulmaSayisi == can)
        {
            GetComponent<AudioSource>().Play();
            totalBlockNumber++;
            effecktim();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            GetComponent<AudioSource>().Play();
            BlockGoruntusunuDegisitir();
        }

        if (totalBlockNumber == 27)
        {
            winPanel.SetActive(true);
            directionnn.SetActive(false);
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
