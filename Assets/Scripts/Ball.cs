using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField]
    float velocidade = 5f;

    bool bolafoilancada = false;
    float countdown = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá, vamos divertir-nos!!");
        /* Para andar para a esquerda e para a direita
        * 
        * if (Random.value < 0.5f)
        * { 
        *    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
        * } else
        * {
        *    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.left;
        * }
        */

        //Para se mover em qualquer direção
    
    }

    // Update is called once per frame
    void Update()
    {

        if (bolafoilancada == false)
        {
            Debug.Log("Vamos lá!!");

            countdown -= Time.deltaTime;
            if (countdown <= 0.0f)
            {
                bolafoilancada = true;
            }

            if (bolafoilancada == true)
            { 
                GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
            }
        }
    }
}
