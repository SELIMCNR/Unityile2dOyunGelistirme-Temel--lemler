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
        //anyKey:basýlý olduðu sürece çalýþýr.
        //anyKeyDown:basýlý olduðu anda birkez çalýþýr
        if (Input.anyKeyDown)
        {
            Debug.Log("tuþa dokundun");
        }

        if (Input.anyKey)
        {
            Debug.Log("tuþa hala basýyon");
        }
    }
}
