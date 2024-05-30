using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;


public class CanvasStart : MonoBehaviour
{
   [SerializeField] private GameObject menuOpciones;
   [SerializeField] private AudioMixer audioMixer;
   public Slider slider;
   public float sliderValor;
   public Image panelBrillo;



    public void Jugar(){
        
        // Guardar el valor del slider antes de cambiar de escena
        PlayerPrefs.SetFloat("brillo", slider.value);
        // Cargar la escena principal del juego, que es la escena 1
        SceneManager.LoadScene(1);
        slider.onValueChanged.AddListener(delegate { CambiarBrillo(slider.value); });
         

    }
    
    public void Salir(){
        Debug.Log("Se cierra el juego");
        Application.Quit();
        }

    public void Opciones(){
        menuOpciones.SetActive(true);
    }  
    public void BotonRegresar(){
        menuOpciones.SetActive(false);
    }  
    public void PantallaCompleta(bool pantallaCompleta){
        Screen.fullScreen=pantallaCompleta;
    }

    public void CambiarVolumen(float volumen){
        audioMixer.SetFloat("Volumen",volumen);
    }

    public void CambiarBrillo(float valor){
        sliderValor=valor;
        PlayerPrefs.SetFloat("brillo",sliderValor);
        panelBrillo.color=new Color(panelBrillo.color.r,panelBrillo.color.g,panelBrillo.color.b,slider.value);

    }

    void Start(){
        slider.value=PlayerPrefs.GetFloat("brillo",0.5f);
        panelBrillo.color=new Color(panelBrillo.color.r,panelBrillo.color.g,panelBrillo.color.b,slider.value);
    
     // Añadir listener para guardar el valor del slider cuando cambie
        slider.onValueChanged.AddListener(delegate { CambiarBrillo(slider.value); });
    }
}

