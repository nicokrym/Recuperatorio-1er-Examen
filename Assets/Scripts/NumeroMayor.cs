using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroMayor : MonoBehaviour
{
    public int numeroA;
    public int numeroB;
    bool aMayor;
    bool iguales;

    // Start is called before the first frame update
    void Start()
    {
        if (numeroA > numeroB)
        {
            aMayor = true;
        }
        else if (numeroA < numeroB)
        {
            aMayor = false;
        }
        else if (numeroA == numeroB)
        {
            iguales = true;
        }

        if (aMayor == true)
        {
            Debug.Log("El mayor de los dos números ingresados es " + numeroA);
        }
        else if (aMayor == false)
        {
            Debug.Log("El mayor de los dos números ingresados es " + numeroB);
        }
        else if (iguales == true)
        {
            Debug.Log("Los número son iguales entre sí");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
