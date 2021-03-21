using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float velocidade = 0.5f;

    [SerializeField] float alturaPaddle = 1f;

    // Update is called once per frame
    void Update()
    {
        /*
         * se tecla para cima premida
         * então subir
         * senão tecla para baixo premida
         * então descer 
         */


        //Mover a raquete
        if(Input.GetKey(KeyCode.UpArrow))
        {
            //Sobe
            //transform.position =
              //transform.position + velocidade * Vector3.up;

            transform.position += velocidade * Vector3.up * Time.deltaTime;

        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            //Desce
            //transform.position =
              //transform.position + velocidade * Vector3.down;

            transform.position += velocidade * Vector3.down * Time.deltaTime;
        }

        //Verificar os limites (com ifs)

        //float alturaCamera = Camera.main.orthographicSize;

        //if(transform.position.y >= alturaCamera - 0.5f)
        //{
        //variável auxiliar para poder alterar o valor de y do transform.position
        //Vector3 positionAux = transform.position; 
        //positionAux.y = alturaCamera - 0.5f;
        //transform.position = positionAux; 
        //}

        //if(transform.position.y <= -alturaCamera + 0.5f)
        //{
        //variável auxiliar para poder alterar o valor de y do transform.position
        //Vector3 positionAux = transform.position;
        //positionAux.y = -alturaCamera + 0.5f;
        //transform.position = positionAux;

        //}




        //Verificar os limites (com clamp)

        float alturaCamera = Camera.main.orthographicSize;

        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(positionAux.y, -alturaCamera + (alturaPaddle * 0.5f), alturaCamera - (alturaPaddle * 0.5f));
        transform.position = positionAux;
    }
}
