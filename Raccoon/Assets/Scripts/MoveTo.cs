using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent worker;


    // Start is called before the first frame update
    void Start()
    {
        worker = GetComponent<NavMeshAgent>();
    }



    // Update is called once per frame
    void Update()
    {
        worker.destination = goal.position;
    }
}
