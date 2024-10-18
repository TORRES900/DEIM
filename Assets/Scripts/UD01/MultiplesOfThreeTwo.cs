using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    void Start()
    {
        ShowMultiplesOfThreeAndTwo();
    }

    void ShowMultiplesOfThreeAndTwo()
    {
        Debug.Log("Múltiplos de 3 y de 2 entre 0 y 100:");

        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                Debug.Log(i); 
            }
        }
    }
}
