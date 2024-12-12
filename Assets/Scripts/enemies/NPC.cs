using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC : MonoBehaviour
{
    Transform NPCcameraPoint;
    TMPro.TextMeshPro textMeshPro;
    Outline colorOutline;

    [SerializeField] float RotationTime;

    // Start is called before the first frame update

    public void interact(Transform interacter)
    {
        Debug.Log("hola");

        transform.DOLookAt(interacter.position, RotationTime, AxisConstraint.Y);//.OnComplete(() => Dialogesystem.UNIQUESYSTEM.interactDialoge());

    }
}