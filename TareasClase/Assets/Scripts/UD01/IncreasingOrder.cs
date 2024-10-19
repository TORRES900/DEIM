using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    public int number1;
    public int number2;
    public int number3;

    void Start()
    {
        CheckIncreasingOrder();
    }

    void CheckIncreasingOrder()
    {
        if (number1 < number2 && number2 < number3)
        {
            Debug.Log("Los n�meros est�n en orden creciente: " + number1 + ", " + number2 + ", " + number3);
        }
        else
        {
            Debug.Log("Los n�meros NO est�n en orden creciente.");
        }
    }
}
