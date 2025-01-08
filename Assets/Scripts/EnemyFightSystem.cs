using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFightSystem : MonoBehaviour
{
    [SerializeField]float fightspeed;
    NavMeshAgent FightAgent;
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
        
        TargetDirection = main.maintarget.transform.position - transform.position;
        FightAgent.SetDestination(main.maintarget.transform.position);
    }

}
