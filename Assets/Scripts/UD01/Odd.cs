using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    void Start()
    {
        ShowOddNumbers();
    }

    void ShowOddNumbers()
    {
        Debug.Log("Números impares entre 0 y 100:");

        for (int i = 1; i < 100; i += 2)
        {
            Debug.Log(i); 
        }
    }
}
