using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField]
    float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
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
        GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
