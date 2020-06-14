using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDado : MonoBehaviour
{
    [SerializeField]
    int dado = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiradaDado();
    }

    void TiradaDado()
    {
        switch (dado)
        {
            case 7:
            case 15:
                Debug.Log("Daño Nomal");
                break;
            case 20:
                Debug.Log("Daño crítico");
                break;
            default:
                Debug.Log("Has fallado la tirada. El enemigo te ha esquivado");
                break;
        }
    }
}
