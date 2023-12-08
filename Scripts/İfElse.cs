using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İfElse : MonoBehaviour
{
    //İf-Else
    public int sayi=5;
    public int sayi2=15;

    // Start is called before the first frame update
    void Start()
    {

        if (sayi == 5)
        {
            Debug.Log("Doğru");
        }
        else
        {
            Debug.Log("Yanlış");
        }

        if(sayi <= 6) {
            Debug.Log("Sayi 6 tan küçük");
        }

        if(sayi <= 7 && sayi2>=7) 
        {
            Debug.Log("Sayilar 7 den büyük");
        }
        if (sayi != 7 || sayi2 >= 7)
        {
            Debug.Log("Sayi 7 den büyük");
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
