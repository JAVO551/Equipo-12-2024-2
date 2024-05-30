using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PausarJuego: MonoBehaviour
{
[SerializeField] private GameObject bottonPausa;
[SerializeField] private GameObject menuPausa;
private bool juegoPausaTecla=false;
    
    public void Update(){//Para que se pause el juego con el boton ESC
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(juegoPausaTecla){
                Reanudar();
            }else{
                Pausa();
            }
        }
    }


    public void Pausa(){
    juegoPausaTecla=true;    
    Time.timeScale=0f;//pausar el juego
    bottonPausa.SetActive(false);
    menuPausa.SetActive(true);
    }
    public void Reanudar(){
    juegoPausaTecla=false;    
    Time.timeScale=1f;//reaunudarlo
    bottonPausa.SetActive(true);
    menuPausa.SetActive(false);
    }

    public void Reiniciar(){
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        bottonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void MenuPrincipal(){
        Time.timeScale=1f;
        SceneManager.LoadScene(0);//Escena del inicio es el 0
    }

}
