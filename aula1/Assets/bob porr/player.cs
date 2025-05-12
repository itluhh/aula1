using System;
using System.IO;
using UnityEngine;

public class player : MonoBehaviour
{
    private int numero = 4;

    public float velocidade = 40;
    // Start is called on the first execution of update after the MonoBehaviour is created

    void Start()
    {
        numero = 0;
    }
    // update is called once per frame 

    void Update()
    {
        //Debug. Log (numero);
        //Debug. Log (numero) = numero + 1;

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
        }
    }
}