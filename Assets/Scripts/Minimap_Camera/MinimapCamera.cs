using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamera : MonoBehaviour
{
    [SerializeField] player Jugador;
    Vector3 PlayerDistance;
    // Start is called before the first frame update
    void Start()
    {
        PlayerDistance = transform.position - Jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerDistance;
    }
}
