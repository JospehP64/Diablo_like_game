using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFightSystem : MonoBehaviour
{
    [SerializeField] Animator monster_animator;
    [SerializeField]float fightspeed;
    [SerializeField]NavMeshAgent FightAgent;
    [SerializeField] enemy main;
    [SerializeField]float distanciaDeAtaque;
    Vector3 TargetDirection;
    // Start is called before the first frame update
    private void Awake()
    {
        main.fight = this;
    }
    //awake vs onenable vs start. VIDEO PARA GUIARTE
    private void OnEnable()
    {
        FightAgent.speed = fightspeed;
        FightAgent.stoppingDistance = distanciaDeAtaque;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (main.maintarget != null && FightAgent.CalculatePath(main.maintarget.position, new NavMeshPath()))
        {
            FightAgent.SetDestination(main.maintarget.transform.position);
            if (FightAgent.remainingDistance < distanciaDeAtaque)
            {
                monster_animator.SetTrigger("attack");
            }
        }
        else
        {
            main.PatrolActivated();
        }
        
        
    }
    void FocusTarget()
    {
        Vector3 attackdrirection = (main.maintarget.transform.position - this.transform.position).normalized;
        TargetDirection.y = 0;
        Quaternion TargetRotation = Quaternion.LookRotation(attackdrirection);
        transform.rotation = TargetRotation;
    }

}
