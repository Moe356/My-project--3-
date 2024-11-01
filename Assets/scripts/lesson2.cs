using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    
     int Multiply(int a, int b)
    {
        return a * b;
    }

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int result = Multiply(i, 5);
            Debug.Log("5 x {i} = {result}");
        }
    }
}