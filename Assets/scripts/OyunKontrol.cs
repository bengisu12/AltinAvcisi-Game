using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public bool OyunAktif = true;
    public int altinsayi=0;
    public UnityEngine.UI.Text AltinSayisiText;
    public UnityEngine.UI.Button baslabutonu;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void altinarttir(){
        altinsayi +=1;
        AltinSayisiText.text = "" + altinsayi;
    }
    public void OyunaBasla(){
        OyunAktif = true;
        baslabutonu.gameObject.SetActive(false);
    }
}
