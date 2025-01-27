using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MissionSO")]
public class MisionSO : ScriptableObject
{

    //RECUERDA TODOS ESTOS VALORES JUNTO CON LOS EVENTOS
    public string Mision_estado_Inicial;//Primera orden de la misi�n. Ejemplo: recoje 3 setas y cristales
    public string Mision_estado_final;//ultima orden de la misi�n. Ejemplo: Vuelve con "Lusien"(NPC)

    public bool repetirMision;//Si no has cumplido la misi�n, se repite
    public int maxRepeticiones; //el m�ximo de veces que se repite si no has cumplido la misi�n. Ejemplo: 1/3 setas (3 ser�a el m�ximo)
    public int estadoActual;//estado actual de la misi�n

    public int MissionID;//Identificador para diferenciar la misi�n de otras
    //RECUERDA:  LA "?" de, por ejemplo, eVENTOVARIABLE?.INVOKE, ES INVOKE SEGURO. SE ASEGURA DE QUE HAY "SUBSCRIPTORES" O QUE ALGUIEN ESTE "LOGGEADO" AL EVENTO
    //SI NO LO PONES (QUE ES OBLIGATORIO), ES POSIBLE QUE, AL NO HABER "SUBSCRIPTORES", SE PRODUCE UN ERROR EN EL JUEGO. SIEMPRE USA LA "?" EN CADA INVOKE QUE REALICES

    //
}
