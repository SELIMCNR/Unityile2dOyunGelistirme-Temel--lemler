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
        Time.timeScale = 0.5f; //Oyun zaman akýþý düzenler oyun hýzý ayarlar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Deneme()); //Ienumarayor fonksiyonu çalýþtý

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            StopAllCoroutines();  //tüm iþlemi bitir durdur.
        }
    }
    //IEnumerator : belli bir saniye bekletip baþka bir iþlem yapma.
    IEnumerator Deneme()
    {
        Debug.Log("Game start");
        yield return new WaitForSeconds(3); //3saniye bekle
        Debug.Log("Coroutine");
        yield return new WaitForSeconds(bekleme); //dýþardan gelen deðere göre bekle

    }
}
