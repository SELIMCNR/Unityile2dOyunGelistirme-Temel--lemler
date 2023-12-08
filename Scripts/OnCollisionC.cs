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

        //klavye hareketi Rigiobody göre yer çekimine karþý hareket
        float horizontalInput = Input.GetAxis("Horizontal") ; // yatay
        float verticalInput = Input.GetAxis("Vertical") ; //dikey

        Vector2 movement = new Vector2(horizontalInput, verticalInput);  //objeye hýz ver
        GetComponent<Rigidbody2D>().velocity = movement;    //2d objeye hareket ver rigibodysine

    }

    //Oncollision sert çarpýþma nesneler iç içe geçmez.
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

     
    //OnTrigger yumuþak çarpýþma  nesneler iç içe geçebilir
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

    // 2 d de component ve onTrigger onCollider2d olmalý.
}
