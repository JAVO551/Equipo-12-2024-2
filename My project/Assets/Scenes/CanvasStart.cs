using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasStart : MonoBehaviour
{
   



    public void Jugar(){
        
        // Cargar la escena principal del juego, que es la escena 1
        SceneManager.LoadScene(1);


    }
    
    public void Salir(){
        Debug.Log("Se cierra el juego");
        Application.Quit();
        }
}

