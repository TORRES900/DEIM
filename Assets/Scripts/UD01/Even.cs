using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    void Start()
    {
        ShowEvenNumbers();
    }

    void ShowEvenNumbers()
    {
        Debug.Log("Números pares entre 0 y 100:");

        for (int i = 0; i <= 100; i += 2)
        {
            Debug.Log(i); 
        }
    }
}
