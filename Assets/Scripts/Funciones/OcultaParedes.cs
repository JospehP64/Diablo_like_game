using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultaParedes : MonoBehaviour
{
    [SerializeField]Renderer[] walls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.CompareTag("Player"))
        {
            foreach (Renderer wall in walls)
            {
                //Color newcolor = wall.material.color;
                //newcolor.a = 0.5f;
                //
                //wall.material.color = newcolor;
                wall.enabled = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.CompareTag("Player"))
        {
            foreach (Renderer wall in walls)
            {
                //Color newcolor = wall.material.color;
                //newcolor.a = 0.5f;
                //
                //wall.material.color = newcolor;
                wall.enabled = true;
            }
        }
    }
}
