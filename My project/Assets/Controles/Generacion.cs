using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generacion : MonoBehaviour
{
    public GameObject[] enemigos;
    public float tiempoGeneracion;
    public float decremento;
    public float limite;
    public float tiempoInicio;
    int numRandom;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempoGeneracion<=0){
           numRandom=Random.Range(0,enemigos.Length);
            Instantiate(enemigos[numRandom],transform.position,Quaternion.identity);
            if(tiempoInicio>limite){
                tiempoInicio-=decremento;
            }

            tiempoGeneracion=tiempoInicio;


        }else {
            tiempoGeneracion-=Time.deltaTime;
        }
    }
}
