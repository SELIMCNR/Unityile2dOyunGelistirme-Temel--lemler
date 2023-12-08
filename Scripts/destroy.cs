using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject nesne;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
         // Destroy(nesne); //objeyi yok et. this.GameObject mevcut objeyi sil
            Destroy(nesne, 3); //3saniye sonra sil eklenen nesneyi sil
            Destroy(this.gameObject, 3.5f); //3.5 saniye sonra mevcut nesneyi sil
        }
    }
}
