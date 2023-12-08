using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        //klavye hareketi Rigiobody g�re yer �ekimine kar�� hareket
        float horizontalInput = Input.GetAxis("Horizontal") ; // yatay
        float verticalInput = Input.GetAxis("Vertical") ; //dikey

        Vector2 movement = new Vector2(horizontalInput, verticalInput);  //objeye h�z ver
        GetComponent<Rigidbody2D>().velocity = movement;    //2d objeye hareket ver rigibodysine

    }

    //Oncollision sert �arp��ma nesneler i� i�e ge�mez.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Temas etti");
    }
    private void OnCollisionStay(Collision collision) {
        Debug.Log("Temas ediyor");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Temas bitti");
    }

     
    //OnTrigger yumu�ak �arp��ma  nesneler i� i�e ge�ebilir
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Temas etti");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Temas ediyor");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Temas etti");
    }

    // 2 d de component ve onTrigger onCollider2d olmal�.
}
