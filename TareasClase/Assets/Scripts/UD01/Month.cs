using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    public int monthNumber;

    void Start()
    {
        PrintMonthName();
    }

    void PrintMonthName()
    {
        if (monthNumber == 1)
            Debug.Log("Enero");
        else if (monthNumber == 2)
            Debug.Log("Febrero");
        else if (monthNumber == 3)
            Debug.Log("Marzo");
        else if (monthNumber == 4)
            Debug.Log("Abril");
        else if (monthNumber == 5)
            Debug.Log("Mayo");
        else if (monthNumber == 6)
            Debug.Log("Junio");
        else if (monthNumber == 7)
            Debug.Log("Julio");
        else if (monthNumber == 8)
            Debug.Log("Agosto");
        else if (monthNumber == 9)
            Debug.Log("Septiembre");
        else if (monthNumber == 10)
            Debug.Log("Octubre");
        else if (monthNumber == 11)
            Debug.Log("Noviembre");
        else if (monthNumber == 12)
            Debug.Log("Diciembre");
        else
            Debug.Log("Por favor introduce un número del 1 al 12.");
    }
}

