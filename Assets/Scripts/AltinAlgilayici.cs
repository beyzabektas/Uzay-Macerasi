using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltinAlgilayici : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Ayaklar")
        {
            GetComponentInParent<Altin>().AltiniKapat();
            FindObjectOfType<Puan>().AltinKazan();
        }
    }
}
