using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForDöngüsü : MonoBehaviour
{
    public int calismaSayisi;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < calismaSayisi;i++)
        {
            Debug.Log("Unity");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
