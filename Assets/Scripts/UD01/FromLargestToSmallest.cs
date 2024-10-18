using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
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
        System.Array.Reverse(numbers); 

        Debug.Log("Números ordenados de mayor a menor: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
    }
}
