using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAnyKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        //anyKey:bas�l� oldu�u s�rece �al���r.
        //anyKeyDown:bas�l� oldu�u anda birkez �al���r
        if (Input.anyKeyDown)
        {
            Debug.Log("tu�a dokundun");
        }

        if (Input.anyKey)
        {
            Debug.Log("tu�a hala bas�yon");
        }
    }
}
