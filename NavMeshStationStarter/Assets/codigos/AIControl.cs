using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    //criação do Agente agent
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        //Agent interage com NavMeshAgent
        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Update vazio
    }
}
