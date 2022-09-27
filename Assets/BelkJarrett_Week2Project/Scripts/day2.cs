using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day2 : MonoBehaviour
{
    /*    int foo;
        // Start is called before the first frame update
        void Start()
        {
            //Debug.Log("day2 is live!");

            int bar = 5;
            foo = bar;
            Debug.Log("foo is\"" + foo + "\"\nbar is \""
                + bar + "\"\nand foo + bar is \"" + (foo + bar) + "\"");
        }*/


   // float fVal = 5.5f;



    void Start()
    {
        //AddAndPrint(2, 3);
        //SubtractAndPrint(5, 10);
        // multipyAndPrint(3, 5);
        // DivideAndPrint(10, 3);

 /*     int nOne = 5;
        int nTwo = 10;

        int nSum = Add(nOne, nTwo);
        Debug.Log(nSum);
        Debug.Log(nSum + 1);

        Debug.Log(Add(10, 20));*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddAndPrint(int nA, int nB)
    {
        Debug.Log("The Sum of " + nA + " + " + nB + " = " + (nA + nB));
    }

    int Add(int nA, int nB)
    {
        int nReturn = 0; 
        nReturn = nA + nB;
        return nReturn;
    }
    void SubtractAndPrint(int nA, int nB)
    {
        Debug.Log("The difference of " + nA + " - " + nB + " = " + (nA - nB));
    }
    void multipyAndPrint(int nA, int nB)
    {
        Debug.Log("The product of " + nA + " * " + nB + " = " + (nA * nB));
    }
    void DivideAndPrint(float fA, int nB)
    {
        Debug.Log("The quotient of " + fA + " / " + nB + " = " + (fA / nB));
    }
}
