using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public int number;

    void Start()
    {
        CalculateSum();
    }

    void CalculateSum()
    {
        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        Debug.Log("La suma de los números del 1 al " + number + " es: " + sum);
    }
}
