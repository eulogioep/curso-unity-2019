using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string characterAction = "Magic";

        switch (characterAction)
        {
            case "Attack":
            case "Magic"://Se pueden agrupar varios case si van a ejecutar el mismo código
                Debug.Log("Atacando al enemigo");
                break;
            case "Heal":
                Debug.Log("Tomando una poción");
                break;
            case "Deffend":
                Debug.Log("Escudo en alto");
                break;
            default:
                Debug.Log("Acción aún no programada");
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
