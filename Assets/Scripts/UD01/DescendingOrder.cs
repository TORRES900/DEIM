using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    public int number1;
    public int number2;
    public int number3;

    void Start()
    {
        CheckDescendingOrder();
    }

    void CheckDescendingOrder()
    {
        if (number1 > number2 && number2 > number3)
        {
            Debug.Log("Los números están en orden decreciente: " + number1 + ", " + number2 + ", " + number3);
        }
        else
        {
            Debug.Log("Los números NO están en orden decreciente.");
        }
    }
}
