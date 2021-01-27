using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_bar2 : MonoBehaviour
{
    private AI_top2 oyundakiTop;
    private void Start()
    {
        oyundakiTop = GameObject.FindObjectOfType<AI_top2>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 topunKonumu = oyundakiTop.transform.position;
        Vector3 oyun_bari_konumu = new Vector3(topunKonumu.x, this.transform.position.y, this.transform.position.z);
        oyun_bari_konumu.x = Mathf.Clamp(topunKonumu.x, 17.7f, 31f);
        this.transform.position = oyun_bari_konumu;
    }
}
