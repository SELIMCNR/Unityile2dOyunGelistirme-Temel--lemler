using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

        //Klavyeden veri alma
        //GetKeyDown  : Tu�a bas�ld��� anda
        //GetKeyUp    : Tusa bas�p elimizi �ekince
        //GetKey      : Tu�a bas�ld��� s�rece
        //Mouse(fareden veri alma) : 
        //GetMouseButton  : Fareye bas�ld��� s�rece �al���r
        //GetMouseButtonDown  : Fareye bas�ld��� anda �al���r
        //GetMouseButtonUp   : Mouse tu�undan el �ekilince �al���r
        
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("Girdi alindi");
        }

        if(Input.GetMouseButtonDown(0)) //0 sol tu�a bas�ld� , 1 sa� tu� , 2 orta mouse tekeri
        {
            Debug.Log("sol tu�");
        }

        if (Input.GetMouseButtonDown(1))  
        {
            Debug.Log("sa� tu�");
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("orta tu�");
        }
    }
}
