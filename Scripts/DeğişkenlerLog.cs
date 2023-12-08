using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeğişkenlerLog : MonoBehaviour
{

    public int ilkSayi=5;
    public float ikinciSayi=85.5f;
    private string yazi = "Merhaba Unity";
    double s = 54d; //private 

    Boolean b= true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Merhaba"+ilkSayi);
        Debug.Log(yazi);
        Debug.Log(ilkSayi);
        Debug.Log(b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
}
