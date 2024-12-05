using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogo_SO")]
public class SO_dialogos : ScriptableObject
{
    [SerializeField] TextEditor[] m_TextEditor;
    TextAreaAttribute textArea;
}
