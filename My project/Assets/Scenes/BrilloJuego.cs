using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BrilloJuego : MonoBehaviour
{

    public Image panelBrillo;


    // Start is called before the first frame update
    void Start()
    {
        // Recuperar el valor del brillo guardado y aplicarlo
        float sliderValor = PlayerPrefs.GetFloat("brillo", 0.5f);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, sliderValor);

    }

    
}
