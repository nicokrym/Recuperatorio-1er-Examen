using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositivoHastaNueve : MonoBehaviour
{
    public int numero;
    bool positivo;
    bool menor;

    // Start is called before the first frame update
    void Start()
    {
        if (numero > 0)
        {
            positivo = true;
        }

        if (numero < 10)
        {
            menor = true;
        }

        if (positivo == true && menor == true)
        {
            Debug.Log("Es positivo y menor a 10, cumple con las condiciones");
        }
        else
        {
            Debug.Log("No cumple con las condiciones");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
