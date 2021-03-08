using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Exercicio1 : MonoBehaviour
{
    //Exercicio Vetores e Movimentação Continua
    NavMeshAgent navMesh;

    [SerializeField]
    Transform[] Locations;
    int Spawn;

    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        InvokeRepeating("changeLocation", 1, 4);
        print("Exercicio Vetores e Movimentação Continua");
    }


    void changeLocation()
    {
        Spawn++;
        if (Spawn == Locations.Length)
        {
            Spawn = 0;
        }
        navMesh.destination = Locations[Spawn].position;
    }
}
