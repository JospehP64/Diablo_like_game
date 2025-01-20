using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class playerVisual : MonoBehaviour
{
    Animator animator;
    [SerializeField]NavMeshAgent agent;
    private void Awake()
    {
        animator = GetComponent<Animator>();

        //coge la animacion del personaje
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //en función de mi velocidad actual, voy actualizando mi "velocity"
        animator.SetFloat("blen_velocity", agent.velocity.magnitude / agent.speed);
        
    }
}
