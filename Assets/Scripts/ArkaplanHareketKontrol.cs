using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanHareketKontrol : MonoBehaviour
{
    float arkaPlanKonum;
    //Kamera konumuna gore hesapladigimiz icin 20.48/2'yi aliyoruz
    float mesafe = 10.24f;

    // Start is called before the first frame update
    void Start()
    {
        //Biz sadece y konumu ile ilgileniyoruz
        arkaPlanKonum = transform.position.y;
        FindObjectOfType<Gezegenler>().GezegenYerlestir(arkaPlanKonum);
    }

    // Update is called once per frame
    void Update()
    {
        if(arkaPlanKonum + mesafe < Camera.main.transform.position.y)
        {
            ArkaPlanYerlestir();
        }
    }

    void ArkaPlanYerlestir()
    {
        arkaPlanKonum += (mesafe * 2);
        FindObjectOfType<Gezegenler>().GezegenYerlestir(arkaPlanKonum);
        Vector2 yeniPozisyon = new Vector2(0, arkaPlanKonum);
        transform.position = yeniPozisyon;
    }
}
