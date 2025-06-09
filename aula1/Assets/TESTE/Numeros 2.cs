using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Numeros2 : MonoBehaviour
{
    public int Numero;

    private bool resposta;
    private int menor = 0;
    private int maior = 10;
    private int NumeroDeTentativas = 10;

    bool oJogoEstáRodando = true;

    //private Random rand = new Random();
    private int sorteado;

    void Start()
    {
        //sorteado = rand.Next(menor, maior + 1);

        //Debug.Log("Pensei em um numero entre '+menor+' e '+maior+', tente adivinhar");
    }

    void Update()
    {
        //testa o numero quando aparte a tecla de espaço
        if (Input.GetKeyDown(KeyCode.Space)) ;
        {
            //Debug.Log("Você tem +NumeroDeTentativas+ 'tentativas!'");
            int NUmeroDigitado = Numero;

        }
    }







}

  
