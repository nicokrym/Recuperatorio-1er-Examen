using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroSuficiente : MonoBehaviour
{
    public float dinero;
    public float precioA;
    public float precioB;
    float precioTotal;

    // Start is called before the first frame update
    void Start()
    {
        precioTotal = precioA + precioB;

        if (dinero < precioTotal)
        {
            Debug.Log("Dinero insuficiente para pagar");
        }
        else if (dinero == precioTotal)
        {
            Debug.Log("Dinero exacto para pagar");
        }
        else if (dinero > precioTotal)
        {
            Debug.Log("Dinero de sobra para pagar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
