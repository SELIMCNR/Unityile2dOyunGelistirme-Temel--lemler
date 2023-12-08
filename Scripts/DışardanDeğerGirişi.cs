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
        //GetKeyDown  : Tuþa basýldýðý anda
        //GetKeyUp    : Tusa basýp elimizi çekince
        //GetKey      : Tuþa basýldýðý sürece
        //Mouse(fareden veri alma) : 
        //GetMouseButton  : Fareye basýldýðý sürece çalýþýr
        //GetMouseButtonDown  : Fareye basýldýðý anda çalýþýr
        //GetMouseButtonUp   : Mouse tuþundan el çekilince çalýþýr
        
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("Girdi alindi");
        }

        if(Input.GetMouseButtonDown(0)) //0 sol tuþa basýldý , 1 sað tuþ , 2 orta mouse tekeri
        {
            Debug.Log("sol tuþ");
        }

        if (Input.GetMouseButtonDown(1))  
        {
            Debug.Log("sað tuþ");
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("orta tuþ");
        }
    }
}
