using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int vida = 0;
    [SerializeField] Transform target;
    public Transform maintarget;
    public EnemyFightSystem fight;
    public sistemaDeRuta patrol;
    // Start is called before the first frame update
    void Start()
    {
        fight.enabled = false;
        patrol.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
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
