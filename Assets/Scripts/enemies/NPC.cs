using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    Outline colorOutline;
    
    [SerializeField] float RotationTime;

    // Start is called before the first frame update
    
    public void interact(Transform interacter)
    {
        Debug.Log("hola");
        
        transform.DOLookAt(interacter.position, RotationTime, AxisConstraint.Y);
    }
}
