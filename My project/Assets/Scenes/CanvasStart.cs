using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasStart : MonoBehaviour
{
    public void Jugar(){
        SceneManager.LoadScene(1);//Escena del juego principal es el 1
    }
}
