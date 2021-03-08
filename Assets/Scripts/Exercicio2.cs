using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Exercicio2 : MonoBehaviour
{
    //Exercicio Vetores e Movimentação em Grupo
    NavMeshAgent navMesh;

    [SerializeField]
    Transform End;

    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();

        changeLocation();

        print("Exercicio Vetores e Movimentação em Grupo");
    }

    void changeLocation()
    {
        navMesh.destination = End.position;
    }
}
