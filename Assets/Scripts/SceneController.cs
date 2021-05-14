using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public int cofresEnPantalla;
    public GameObject[] Nivel;
    private int IndiceNivel;
    private GameObject objectNivel;

    public Text TextJuego; 

    void Start()
    {
        IndiceNivel = 0;
        objectNivel = Instantiate(Nivel[IndiceNivel]);
        objectNivel.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        cofresEnPantalla = this.GetComponentsInChildren<CofreController>().Length;
        TextJuego.text = "Nivel: " + (IndiceNivel + 1) + 
                         "\nDestruye todos los cofres." +
                         "\nCofres Restantes: " + cofresEnPantalla;
        if(cofresEnPantalla == 0)
        {
            TextJuego.text = "Completaste el Nivel! \nPresione R para el siguiente Nivel";
            Destroy(GameObject.FindWithTag("Bala"));
            if(IndiceNivel == Nivel.Length - 1)
            {
                TextJuego.text = "Completaste el Juego! \nPresione R para volver a empezar";
            }

            if(Input.GetKeyUp(KeyCode.R))
            {
                if(IndiceNivel == Nivel.Length - 1)
                {
                    Destroy(objectNivel);
                    IndiceNivel = 0;
                    objectNivel = Instantiate(Nivel[0]);
                    objectNivel.transform.SetParent(this.transform);
                }
                else
                {
                    Destroy(objectNivel);
                    IndiceNivel += 1;
                    objectNivel = Instantiate(Nivel[IndiceNivel]);
                    objectNivel.transform.SetParent(this.transform);
                }
            }
        }
    }
}
