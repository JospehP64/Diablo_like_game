using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogo_SO")]
public class SO_dialogos : ScriptableObject
{
    [SerializeField] string[] dialogosNPC1, dialogosNPC2;
    TextAreaAttribute textArea;
    [SerializeField] int tiempoEntreLetras;
    public string TieneMision;
    public bool hasMission;
    [SerializeField] GameObject MissionSo;


}
