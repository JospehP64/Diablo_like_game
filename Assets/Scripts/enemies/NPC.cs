using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC : MonoBehaviour 
{
    Dialogesystem SistemaDeDialogo;
    EventManagerSO EventManager;
    SO_dialogos dialogo01;//primer dialogo
    SO_dialogos dialogo02;//segundo dialogo
    SO_dialogos actual;
    MisionSO MisionAsociadaAlNPC;

    //RECUERDA USAR EN EL EVENTMANAGER UN ONENABLE PARA
    //CUANDO LA MISIÓN SE COMPLETE EN EL NPC CON:
    //EVENTMANAGER.ONTERMINARMISION +- CAMBIARMISION
    
    //USAR INTERACTUABLE
    Transform NPCcameraPoint;
    TMPro.TextMeshPro textMeshPro;
    Outline colorOutline;

    [SerializeField] float RotationTime;

    // Start is called before the first frame update

    public void interact(Transform interacter)
    {
        Debug.Log("hola");
        //PARA EL DIALOG, USA EL "DIALOGOACTUAL" PARA CUANDO ESTÉ HABLANDO

        //CUANDO QUIERAS PASAR DE MENSAJE, DEBES DECIR
        //DIALOGOACTUAL = DIALOGONº# (# ES EL NÚMERO QUE SEA)


        transform.DOLookAt(interacter.position, RotationTime, AxisConstraint.Y);//.OnComplete(() => Dialogesystem.UNIQUESYSTEM.interactDialoge());

    }
}