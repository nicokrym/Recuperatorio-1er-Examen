using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinCeros : MonoBehaviour
{
    public float numeroA;
    public float numeroB;
    bool igualACero;

    // Start is called before the first frame update
    void Start()
    {
        if (numeroB == 0)
        {
            igualACero = true;
            return;
        }

        if (igualACero != true)
        {
            Debug.Log(numeroA / numeroB);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
