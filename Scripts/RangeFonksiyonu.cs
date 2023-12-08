using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeFonksiyonu : MonoBehaviour
{
    int sayi1;
    int sayi2;
    float sayi3;

    // Start is called before the first frame update
    void Start()
    {
        sayi1 = Random.Range(5,10); // 5,6,7,8,9 alýr
        sayi2 = Random.Range(1,15); // 1alýr  15 almaz

        Debug.Log(sayi1 + sayi2);
        sayi3 = Random.Range(1f,15f); //1alýr 15 almaz
        Debug.Log(sayi3);

        if (sayi1 > 5)
        {
            Debug.Log("Sayi1 5 ten büyüktür");
        }
    }

    // Update is called once per frame
    void Update()
    {
        sayi3 = Random.Range(1f, 15f); //1alýr 15 almaz
        Debug.Log(sayi3);
    }
}
