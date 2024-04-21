using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionEnemigo : MonoBehaviour
{
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
       Instantiate(objeto,transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
