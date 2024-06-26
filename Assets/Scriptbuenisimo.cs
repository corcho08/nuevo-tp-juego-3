using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public InputField input;

    void Start()
    {
        Random_Number = Random.Range(0, Prefabs.Length);
        ObjetosCayeron = Random.Range(1, 11);

        if (autoGenerate)
        {
            InvokeRepeating(nameof(Clone), 0, freq);
        }
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

    void ButtonRespopnderClick() 
    {
        //if ()
        //{
        //Debug.Log("Ganaste");
        //}
        //else if (input == )
        //{
        //Debug.Log("debe ingresar un resultado");
        //}
        //else
        //{
        //Debug.Log("perdiste");
        //}
    }
}
