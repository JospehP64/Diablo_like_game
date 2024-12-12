using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigos : MonoBehaviour
{
    [SerializeField]Transform ruta;

    List<Vector3> puntos = new List<Vector3>();
     NavMeshAgent agent;
    Vector3 currentDestination;

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
    void Start()
    {
        StartCoroutine(esperarruta()); 
    }

     //Update is called once per frame
    IEnumerator esperarruta()
    {
    agent.SetDestination(currentDestination);
        yield return null;
    }
    void calcularDestino()
    {

    }
}
