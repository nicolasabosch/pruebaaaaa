using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaaa : MonoBehaviour
{
    public int dineroTotal =0;

    public string moneda="";

    void Start()
    {
        int dineroDolares = dineroTotal / 200;
        int dineroEuros = dineroTotal / 210;
        int dineroReales = dineroTotal / 24;

        if (dineroTotal >= 1000)
        {

            switch (moneda)
            {
                case "R":
                    Debug.Log("Tenes $" + dineroReales);
                    break;

                case "D":
                    Debug.Log("Tenes $" + dineroDolares);
                    break;

                case "E":
                    Debug.Log("Tenes $" + dineroEuros);
                    break;

                default:
                    Debug.Log("Pone una moneda valida (R,D,E)");
                    break;

            }

        }

        else
        {
            Debug.Log("Debes tener por lo menos 1000 pesos");
        }
    }

   
}
