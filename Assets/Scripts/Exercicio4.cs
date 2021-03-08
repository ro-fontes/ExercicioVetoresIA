using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Exercicio4 : MonoBehaviour
{
    //Exercicio Vetores e Perseguição
    NavMeshAgent navMesh;

    [SerializeField]
    Transform[] Locations;
    int Spawn;

    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        InvokeRepeating("changeLocation", 1, 2);
        print("Exercicio Vetores e Perseguição");
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
