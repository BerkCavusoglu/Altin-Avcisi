using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    bool oyunDevam=true;
    bool oyunTamam=false;
    public OyunKontrol oyunK;
    public bool oyunAktif = true;
    public int altinSayisi = 0;
    public UnityEngine.UI.Text altinSayisiText;
    public UnityEngine.UI.Button baslaButonu;
    public UnityEngine.UI.Button btn;

   
    void Start()
    {
        GetComponent<AudioSource> ().Play ();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AltinArttir(){
        altinSayisi += 1;
        altinSayisiText.text = "" + altinSayisi;
    }
    public void OyunaBasla(){
        oyunAktif = true;
        baslaButonu.gameObject.SetActive (false);
    }
}
