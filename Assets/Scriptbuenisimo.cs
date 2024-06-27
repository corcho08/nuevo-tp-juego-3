using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scriptbuenisimo : MonoBehaviour
{
    //Invoke Reapiting Variables
    public bool autoGenerate = true;
    public float freq = 1;

    //Variable que contiene la cantidad de Objetos que cayeron
    public int ObjetosCayeron;

    //variable qu va contando las veces que cayeron
    public int i = 0;

    //Lista de los Prefabs
    public GameObject[] Prefabs;

    //Numero rando
    public int Random_Number;


    //Vincula el inputfield con lo que escribas en el texto
    public InputField InputNumber;

    public Text textoNotificaciones;

    public GameObject panelNotificaciones;

    public GameObject panelError;

    public GameObject panelRespuesta;

    public Text botonJugardenuevo;

    void Start()
    {
        Random_Number = Random.Range(0, Prefabs.Length);
        ObjetosCayeron = Random.Range(1, 11);

        if (autoGenerate)
        {
            InvokeRepeating(nameof(Clone), 0, freq);
        }
        panelNotificaciones.SetActive(false);
        panelError.SetActive(false);
    }

    void Update()
    {
        
    }

    public void Clone()
    {
        if (i < ObjetosCayeron)
        {
            Instantiate(Prefabs[Random_Number], new Vector3(Random.Range(-137, 400), 260, 700), Prefabs[Random_Number].transform.rotation);
            i++;
        }
    }

    public void ButtonRespopnderClick() 
    {
        if (InputNumber.text == "")
        {
            panelError.SetActive(true);
            panelRespuesta.SetActive(false);
        }
        else if (InputNumber.text == ObjetosCayeron.ToString()) 
        {
            panelNotificaciones.SetActive(true);
            panelRespuesta.SetActive(false);
            textoNotificaciones.text = "El resultado es correcto";
            botonJugardenuevo.text = "REINICIAR DESAFIO";
        }
        else         
        {
            panelNotificaciones.SetActive(true);
            panelRespuesta.SetActive(false);
            textoNotificaciones.text = "El resultado es incorrecto";
            botonJugardenuevo.text = "VOLVER A INTENTARLO";
        }
    }

    public void botonError()
    {
        panelError.SetActive(false);
        panelRespuesta.SetActive(true);
    }

    public void Jugardenuevo()
    {
        if (InputNumber.text == ObjetosCayeron.ToString())
        {
            SceneManager.LoadScene("FirstScene");
        }
        else
        {
            panelNotificaciones.SetActive(false);
            panelRespuesta.SetActive(true);
        }
    }

    public void Salir()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }
}
