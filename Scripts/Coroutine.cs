using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public float bekleme;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 0.5f; //Oyun zaman ak��� d�zenler oyun h�z� ayarlar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Deneme()); //Ienumarayor fonksiyonu �al��t�

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            StopAllCoroutines();  //t�m i�lemi bitir durdur.
        }
    }
    //IEnumerator : belli bir saniye bekletip ba�ka bir i�lem yapma.
    IEnumerator Deneme()
    {
        Debug.Log("Game start");
        yield return new WaitForSeconds(3); //3saniye bekle
        Debug.Log("Coroutine");
        yield return new WaitForSeconds(bekleme); //d��ardan gelen de�ere g�re bekle

    }
}
