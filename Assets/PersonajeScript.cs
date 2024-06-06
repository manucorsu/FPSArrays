﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{
    public int nivelHambre;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ConsumirAlimento(int valorAlimenticio)
    {
        nivelHambre -= valorAlimenticio;
        if (nivelHambre <= 0)
        {
            nivelHambre = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        if (alimento)
        {
            ConsumirAlimento(alimento.valorAlimenticio);
            Destroy(other.gameObject);
        }
    }
}
