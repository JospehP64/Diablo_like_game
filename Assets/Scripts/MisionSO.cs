using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MissionSO")]
public class MisionSO : ScriptableObject
{

    //RECUERDA TODOS ESTOS VALORES JUNTO CON LOS EVENTOS
    public string Mision_estado_Inicial;//Primera orden de la misión. Ejemplo: recoje 3 setas y cristales
    public string Mision_estado_final;//ultima orden de la misión. Ejemplo: Vuelve con "Lusien"(NPC)

    public bool repetirMision;//Si no has cumplido la misión, se repite
    public int maxRepeticiones; //el máximo de veces que se repite si no has cumplido la misión. Ejemplo: 1/3 setas (3 sería el máximo)
    public int estadoActual;//estado actual de la misión

    public int MissionID;//Identificador para diferenciar la misión de otras
    //RECUERDA:  LA "?" de, por ejemplo, eVENTOVARIABLE?.INVOKE, ES INVOKE SEGURO. SE ASEGURA DE QUE HAY "SUBSCRIPTORES" O QUE ALGUIEN ESTE "LOGGEADO" AL EVENTO
    //SI NO LO PONES (QUE ES OBLIGATORIO), ES POSIBLE QUE, AL NO HABER "SUBSCRIPTORES", SE PRODUCE UN ERROR EN EL JUEGO. SIEMPRE USA LA "?" EN CADA INVOKE QUE REALICES

    //
}
