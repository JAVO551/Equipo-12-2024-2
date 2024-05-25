using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFondo : MonoBehaviour
{
    [Range(-2f,2f)]
    public float velocidad=1f;
    private float offset;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
    mat=GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update(){
        offset+=(Time.deltaTime*velocidad)/10f;
        mat.SetTextureOffset("_MainTex",new Vector2(0,offset));

    }
    
}
