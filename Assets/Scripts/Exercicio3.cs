using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Exercicio3 : MonoBehaviour
{
    //Exercicio Vetores e Movimentação Uniforme
    NavMeshAgent navMesh;

    [SerializeField]
    Transform End;

    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();

        navMesh.destination = End.position;

        print("Exercicio Vetores e Movimentação Uniforme");
    }
}
