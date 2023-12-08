using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void switch1()
        {
        int rastgele = Random.Range(1, 5);
        Debug.Log(rastgele);

        switch(rastgele)
        {
            case 1:
                Debug.Log("Sayiniz 1");
                break;
            case 2:
                Debug.Log("Sayiniz 2");
                break;
            case 3:
                Debug.Log("Sayiniz 3");
                break;
            default:
                Debug.Log("Tanimsiz sayi");
                break;
        }

}
}
