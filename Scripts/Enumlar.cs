using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumlar : MonoBehaviour
{
    //Enum : kendi veri tiplerimiz belirler.

   public enum RenkSec
    {
        mavi,yeþil,kýrmýzý
    };

    public RenkSec  renk;
    public Color maviRenk, yeþilRenk, kýrmýzýRenk;
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
            case RenkSec.yeþil:
                GetComponent<SpriteRenderer>().color = yeþilRenk;
                break;
            case RenkSec.kýrmýzý:
                GetComponent<SpriteRenderer>().color = kýrmýzýRenk;
                break;
        
        }

    }
}
