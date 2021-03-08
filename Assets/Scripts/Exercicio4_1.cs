using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Exercicio4_1 : MonoBehaviour
{
    //Exercicio Vetores e Perseguição
    NavMeshAgent navMesh;

    [SerializeField]
    GameObject Player;

    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        changeLocation();
    }
    void changeLocation()
    {
        navMesh.destination = Player.transform.position;
    }
}
