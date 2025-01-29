using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Setas : MonoBehaviour
{
    EventManagerSO eventManager; //PARA AVISAR AL EVENTMANAGER 
    //DE QUE HAS RECOGIDO EL OBJETO Y ACTUALICE LA MISIÓN
    //USA UN INTERACTUABLE PARA ESTE SCRIPT DE OBJETO


    MisionSO mision; //LA MISION A LA QUE SE LE ASIGNA


    //LOS CAMBIOS AL INTERACTUAR CON EL OBJETO.
    //SI LA MISIÓN NO CUMPLE CON LOS OBJETOS, SE ACTUALIZA
    //PERO NO SE COMPLETA
    //----------------------
    //If (ESTADOACTUAL < ESTADOFINAL) {
    //
    //SE REPITE MISION(SE ACTUALIZA LA MISION)
    //
    //}
    //ELSE {
    //SE TERMINA LA MISION(SE ENVIA UNA "NOTIFIACION" AL EVENTMANAGER)
    //PARA QUE TERMINE LA MISIÓN)
    //
    //-----------------------------
    //RECUERDA QUE EL EVENTMANAGER SOLO ENVIA UN MENSAJE AL SCRIPT DE MISIONES
    //COMPARALO CON UN SISTEMA DE SERVIDORES 
    //(CLIENTE > SERVIDOR > IDENTIFICADOR O PUESTO DE RED (IP)
    //

    //importante: USA [NONSERIALIZED] 
    //PARA QUE LAS VARIABLES DE LOS SCRIPTABLE OBJECTS NO SE GUARDEN]

    Outline outline_item;

    private void Awake()
    {
        outline_item = GetComponent<Outline>();
    }
    private void OnMouseEnter()
    {
        outline_item.enabled = true;
        
    }
    private void OnMouseExit()
    {
        outline_item.enabled = false;
    }
}
