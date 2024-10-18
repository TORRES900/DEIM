using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    public int number1;
    public int number2;
    public int number3;

    void Start()
    {
        SortAndDisplayNumbers();
    }

    void SortAndDisplayNumbers()
    {
        int[] numbers = { number1, number2, number3 };

        System.Array.Sort(numbers);

        Debug.Log("Números ordenados de menor a mayor: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
    }
}
