using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FonksiyonMetot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() // birkez çalýþýr oyun baþýnda
    {
        Debug.Log("Start fonksiyonu");
        ilkFonksiyon();
    }

    // Update is called once per frame
    void Update() //Update : her karede çalýþýr performansa göre deðiþir
    {
        Debug.Log("update fonksiyonu");
        ikinciFonksiyon();
    }

    private void FixedUpdate() //fixedUpdate:  her karede çalýþýr performansa göre deðiþmez
    {   //Savaþ oyunlarýnda kullanýlýr bug olmamasý için
        Debug.Log("Fixed update fonksiyonu");
        ilkFonksiyon();
    }

    void ilkFonksiyon()
    {
        Debug.Log("ilk fonksiyon");
    }
    void ikinciFonksiyon()
    {
        Debug.Log("Ýkinci fonksiyon");
    }
}