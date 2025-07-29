using System;
using UnityEngine;

public class NUMBERS : MonoBehaviour
{
    private int A;
    private int B;
    private int C;

    void Start()
    {
        A = 23;
        B = 12;
        C = (A + B);
        C = Soma(A, B);

        Debug.Log(C);
    }
    int Soma(int A, int B)
    {
        return A + B;
    }

}   
 

 



