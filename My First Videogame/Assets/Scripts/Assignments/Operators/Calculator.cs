using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleClac : MonoBehaviour
{
    //Access Modifier DataType Name;

    public int numberA = 10;
    public int numberB = 33;
    public int numberC = 7;

    public float numberD = 33.0f;
    public float numberE = 7.0f;

    // + - * / %

    // Start is called before the first frame update
    void Start()
    {
        Add();
        Sub();
        Mult();
        Div();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    void Add()
    {
        int total;

        total = numberA + NumberB;

        Debug.Log(numberA +" + "+ numberB +" = "+ total);
    }

    void Sub()
    {
    int total;

    total = numberB - NumberC;

    Debug.Log(numberB +" - "+ numberC +" = "+ total);
    }

    void Mult()
    {
    int total;

    total = numberB * NumberB;

    Debug.Log(numberB +" * "+ numberB +" = "+ total);
    }

    void Div()
{
    int total;
    int rem;
    float tot;

    total = numberB / numberC;
    rem = numberB % numberC;
    tot = numberD / numberE;


    Debug.Log(numberB + " / " + numberC + " = " + total);
    Debug.Log("remainder = " + rem);
    Debug.Log(numberD + " / " + numberE + " = " + tot);
    }
}