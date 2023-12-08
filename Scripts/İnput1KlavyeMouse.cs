using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İnput1KlavyeMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    /*
   
    public float speedHorizantal = 5f; // Hareket hızı
    public float speedVertical = 1.0f;

    void Update()
    {
     
        //klavye hareketi 
        float horizontalInput = Input.GetAxis("Horizontal") *speedHorizantal; // yatay
        float verticalInput = Input.GetAxis("Vertical") *speedVertical; //dikey

        Vector2 movement = new Vector2(horizontalInput, verticalInput);  //objeye hız ver
        transform.Translate(movement);
        
    }
    */

 
    public float translationDistance = 1.0f;
    public float translationSpeed = 5.0f;




    public float moveSpeed = 5.0f;

    void Update()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Ensure the object stays in the 2D plane

        // Move the object towards the mouse position
        transform.position = Vector3.Lerp(transform.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}







