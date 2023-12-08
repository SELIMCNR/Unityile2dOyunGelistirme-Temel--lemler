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
        //bool de�i�ken 
        if (cevap)
        {
            Debug.Log("Cevab do�ru");
        }
        else if (!cevap)
        {
            Debug.Log("Cevap do�ru de�il");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            nesne1.SetActive(false); //nesne pasifoldu sol tu� fare
            nesne2.SetActive(true);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            nesne1.SetActive(true); //nesne aktif oldu sa� tu� fare
            nesne2.SetActive(false);
        }
    }
}
