using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Score : MonoBehaviour
{
    public TMP_Text puntuTex;
    public float contador;
    

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player")!=null)
            contador+= 1*Time.deltaTime;
            puntuTex.text=((int)contador).ToString();

    }
}
