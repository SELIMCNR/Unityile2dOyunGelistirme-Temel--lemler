using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumlar : MonoBehaviour
{
    //Enum : kendi veri tiplerimiz belirler.

   public enum RenkSec
    {
        mavi,ye�il,k�rm�z�
    };

    public RenkSec  renk;
    public Color maviRenk, ye�ilRenk, k�rm�z�Renk;
    // Start is called before the first frame update
    void Start()
    {
        RenkVer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RenkVer()
    {
        switch (renk) {
            case RenkSec.mavi:
                GetComponent<SpriteRenderer>().color = maviRenk;
                break;
            case RenkSec.ye�il:
                GetComponent<SpriteRenderer>().color = ye�ilRenk;
                break;
            case RenkSec.k�rm�z�:
                GetComponent<SpriteRenderer>().color = k�rm�z�Renk;
                break;
        
        }

    }
}
