using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour
{
    private NavMeshAgent agent;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(laser, out RaycastHit hitThis))
        {
            if (Input.GetMouseButtonDown(0))
            {
                agent.SetDestination(hitThis.point);
            }
                
            
        }

        
    }
}
