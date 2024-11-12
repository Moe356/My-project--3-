using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    int Multiply(int a, int b)
    {
        return a * b;
    }

    void Start()
    {
        int number = 5;

        for (int i = 1; i <= 10; i++)
        {
            int result = Multiply(number, i);
            Debug.Log(number + " x " + i + " = " + result);
        }
    }
}
