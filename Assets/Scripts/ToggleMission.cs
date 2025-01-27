using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ToggleMission : MonoBehaviour
{
    TMP_Text TextoMision;
    Toggle casillaMision;

    public TMP_Text TextoMision1 { get => TextoMision; set => TextoMision = value; }
    public Toggle CasillaMision { get => casillaMision; set => casillaMision = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //RECUERDA: PRARA PODER HACER CHECK A UN TOGGLE: TOGGLE.isON = true/false
}
