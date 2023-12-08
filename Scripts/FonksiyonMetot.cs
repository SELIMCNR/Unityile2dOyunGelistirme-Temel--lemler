using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FonksiyonMetot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() // birkez �al���r oyun ba��nda
    {
        Debug.Log("Start fonksiyonu");
        ilkFonksiyon();
    }

    // Update is called once per frame
    void Update() //Update : her karede �al���r performansa g�re de�i�ir
    {
        Debug.Log("update fonksiyonu");
        ikinciFonksiyon();
    }

    private void FixedUpdate() //fixedUpdate:  her karede �al���r performansa g�re de�i�mez
    {   //Sava� oyunlar�nda kullan�l�r bug olmamas� i�in
        Debug.Log("Fixed update fonksiyonu");
        ilkFonksiyon();
    }

    void ilkFonksiyon()
    {
        Debug.Log("ilk fonksiyon");
    }
    void ikinciFonksiyon()
    {
        Debug.Log("�kinci fonksiyon");
    }
}