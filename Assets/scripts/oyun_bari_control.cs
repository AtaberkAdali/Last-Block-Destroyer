using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyun_bari_control : MonoBehaviour
{
    public bool otomatik_oyna=false;
    private oyun_topu_control oyundakiTop;

    private void Start()
    {
        oyundakiTop = GameObject.FindObjectOfType<oyun_topu_control>();
    }
    // Update is called once per frame
    void Update()
    {
        if (otomatik_oyna)
        {
            Vector3 topunKonumu = oyundakiTop.transform.position;
            Vector3 oyun_bari_konumu = new Vector3(topunKonumu.x, this.transform.position.y, this.transform.position.z);
            oyun_bari_konumu.x = Mathf.Clamp(topunKonumu.x, 1f, 31f);
            this.transform.position = oyun_bari_konumu;
        }
        else
        {
            fareHareketi();
        }
    }
    void fareHareketi()
    {
        float mauseKonumX = Input.mousePosition.x / Screen.width * 32;
        Vector3 oyun_bari_konumu = new Vector3(mauseKonumX, this.transform.position.y, this.transform.position.z);
        oyun_bari_konumu.x = Mathf.Clamp(mauseKonumX, 1f, 31f);
        this.transform.position = oyun_bari_konumu;
    }
}
