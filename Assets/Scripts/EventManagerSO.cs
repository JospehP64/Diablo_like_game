using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EventSO")]//RECUERDA: CUANDO CREES UN ASSET MENU, SIEMPRE FUERA DE "PUBLIC CLASS"
public class EventManagerSO : ScriptableObject
{
    public event Action OnNewMission;

    void NewMission()
    {

    }
}
