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
        GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
