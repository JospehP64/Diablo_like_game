using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour
{
    [SerializeField] Dialogesystem DialogeSM;
    [SerializeField]int interactDistance;
    NPC RemainingNpc;
    Transform lastNPC;
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
        if (RemainingNpc)
        {
            if (agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
            {
                
                agent.stoppingDistance = 0;
                RemainingNpc.interact(this.transform);
                RemainingNpc = null;
                
                Dialogesystem.UNIQUESYSTEM.interactDialoge();

            }
        }
        

        Ray laser = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(laser, out RaycastHit hitThis))
        {
            if (Input.GetMouseButton(0) && Time.timeScale != 0)
            {
               if( hitThis.transform.TryGetComponent(out NPC npcscript))
                {
                    RemainingNpc = npcscript;
                    
                        agent.stoppingDistance = interactDistance;
                }

                agent.SetDestination(hitThis.point);
            }
                
            
        }

        
    }
}
