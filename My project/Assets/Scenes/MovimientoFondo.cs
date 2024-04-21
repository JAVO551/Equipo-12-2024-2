using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFondo : MonoBehaviour
{
    public float velocidad=1f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    transform.Translate(Vector2.down*velocidad*Time.deltaTime);
    if (transform.position.y<-10f){
        ResetPosition();    
    }
    }

    void ResetPosition(){
        Vector3 currentPosition=transform.position;
        transform.position=new Vector3(currentPosition.x,10f,currentPosition.z);
    }
}
