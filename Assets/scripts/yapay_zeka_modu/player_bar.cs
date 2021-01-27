using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bar : MonoBehaviour
{
    private player_top oyundakiTop;
    private void Start()
    {
        oyundakiTop = GameObject.FindObjectOfType<player_top>();
    }
    // Update is called once per frame
    void Update()
    {
        fareHareketi();
    }
    void fareHareketi()
    {
        float mauseKonumX = Input.mousePosition.x / Screen.width * 32;
        Vector3 oyun_bari_konumu = new Vector3(mauseKonumX, this.transform.position.y, this.transform.position.z);
        oyun_bari_konumu.x = Mathf.Clamp(mauseKonumX, 1f, 14.8f);
        this.transform.position = oyun_bari_konumu;
    }
}
