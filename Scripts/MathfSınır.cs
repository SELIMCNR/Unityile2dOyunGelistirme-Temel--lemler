using UnityEngine;

public class MathfSınır : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed

    private void Start()
    {
        //mutlak değer
        int sayi = 5;
        Debug.Log(sayi);
        Debug.Log(Mathf.Abs(sayi));

        //floor TABANA YUVARLAR AŞAĞI
        float deger = 3.8f;
        Debug.Log (Mathf.Floor(deger)); 
        //CEİL TAVANA YUKARI YUVARLAR
        Debug.Log(Mathf.Ceil(deger));   
        //Round  buçuğa göre yuvarlar
        Debug.Log(Mathf.Round(deger));

    }
    void Update()
    {
        /*Hareket kodu*/
        // Get the user input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the translation vector
        Vector3 translation = new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime;

        // Apply the translation to the GameObject's position
        transform.Translate(translation);
        //Konumu ekrana göre sınırla
        float xPozisyon = Mathf.Clamp(transform.position.x, -6.16f, 6.16f);
        float yPozisyon = Mathf.Clamp(transform.position.y, -6.16f, 6.16f); 
        transform.position = new Vector2(xPozisyon,yPozisyon );
    
    }
}
