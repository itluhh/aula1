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

<<<<<<< HEAD
    private bool oJogoEstáRodando = true;
   // private Random rand = new Random();
    private int sorteado; 
    
    
=======
    bool oJogoEstáRodando = true;

    //private Random rand = new Random();
    private int sorteado;

>>>>>>> 05fddf88fffa29d9e10c61dce984dd14cb0228c2
    void Start()
    {
<<<<<<< HEAD
      //  sorteado = rand.Next(menor, maior + 1);
=======
        //sorteado = rand.Next(menor, maior + 1);
>>>>>>> 0c3b8ceb4300818da60f0138ff9aa51400345ff3

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

  
