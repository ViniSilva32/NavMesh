using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    // Start is called before the first frame update
    void Start()
    {
        //os agentes procuram os gameobjects com a tag "ai"
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {
        // se o usuario clicar com o botão direito do mouse, faça uma ação
        if (Input.GetMouseButtonDown(0))
        {
            //criação do hit
            RaycastHit hit;
            //se o usuario clicar em algum lugar do mapa, tome uma ação
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {   //se onde o player clicou estiver dentro da área definida
                foreach (GameObject a in agents)
                    // o player se move até o ponto onde foi clicado
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }

    }
}
