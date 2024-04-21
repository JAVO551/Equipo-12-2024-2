using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float tiempo;
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        

    transform.Translate(Vector2.down*speed*Time.deltaTime);
    }
}
