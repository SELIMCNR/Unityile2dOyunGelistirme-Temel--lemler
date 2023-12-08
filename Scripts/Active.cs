using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public GameObject nesne1,nesne2;
    public bool cevap;
    // Start is called before the first frame update
    void Start()
    {
        //bool deðiþken 
        if (cevap)
        {
            Debug.Log("Cevab doðru");
        }
        else if (!cevap)
        {
            Debug.Log("Cevap doðru deðil");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            nesne1.SetActive(false); //nesne pasifoldu sol tuþ fare
            nesne2.SetActive(true);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            nesne1.SetActive(true); //nesne aktif oldu sað tuþ fare
            nesne2.SetActive(false);
        }
    }
}
