using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] Transform target;
    public Transform maintarget;
    public EnemyFightSystem fight;
    public sistemaDeRuta patrol;
    // Start is called before the first frame update
    void Start()
    {
        patrol.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void FightModeActivated(Transform target)
    {

        maintarget = target;
        fight.enabled = true;

    }
     public void PatrolActivated()
    {

        
        fight.enabled = false;
            patrol.enabled = true;
    }
}
