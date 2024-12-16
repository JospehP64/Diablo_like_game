using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigos : MonoBehaviour
{
    [SerializeField]float waitSeconds = 2;
    [SerializeField]Transform ruta;

    List<Vector3> puntos = new List<Vector3>();
     NavMeshAgent agent;
    Vector3 currentDestination;
    int IndexCurrentPoint =-1;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        foreach (Transform point in ruta)
        {
            //el enemigo recorre los puntos de su ruta y los añade en su lista
            puntos.Add(point.position);
        }
    }

    // Start is called before the first frame update
    private void Update()
    {
        calcularDestino();
    }
    void Start()
    {
        StartCoroutine(PatroleAndwait()); 
    }

     //Update is called once per frame
    IEnumerator PatroleAndwait()
    {
        while (true)
        {
            calcularDestino() ;
            agent.SetDestination(currentDestination);
            yield return new WaitUntil(() => !agent.pathPending && agent.remainingDistance <= 0.2f);
            yield return new WaitForSeconds(Random.RandomRange(2, 5));
        }
        
    
    }
    void calcularDestino()
    {
        IndexCurrentPoint++;
        if (IndexCurrentPoint >= puntos.Count)//"count" es lo mismo que "length" en arrays
        {
            IndexCurrentPoint = 0;//si me he quedado sin puntos de recorrido, vuelvo al punto 0
        }
        currentDestination = puntos[IndexCurrentPoint];

    }
}
