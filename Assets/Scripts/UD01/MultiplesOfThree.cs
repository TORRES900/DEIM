using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    void Start()
    {
        ShowMultiplesOfThree();
    }

    void ShowMultiplesOfThree()
    {
        Debug.Log("Múltiplos de 3 entre 0 y 100:");

        for (int i = 0; i <= 100; i += 3)
        {
            Debug.Log(i); 
        }
    }
}
