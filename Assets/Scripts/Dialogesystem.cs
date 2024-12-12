using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Dialogesystem : MonoBehaviour
{
    Transform NPCTransformCamera;
    bool escribiendoMensaje;
    [SerializeField]GameObject botonTexto;
    [SerializeField]GameObject PanelDeConversacion;
    //RECUERDA: SIGNLE-TON SE ASEGURA DE QUE ESTA SEA LA UNICA INSTANCIA DEL ESTE SCRIPT Y QUE PUEDAS LLAMAR AL SCRIPT EN CUALQUIER LUGAR. SOLO UNA INSTANCIA PUEDE TENER SINGLE-TON(trono)
    public static Dialogesystem UNIQUESYSTEM;
    [SerializeField]TextMeshPro textoDialogo;
    bool writing;
    int ActualIndex;

    private void Awake()
    {
        if (UNIQUESYSTEM == null)//si el signle-ton(el "trono" est� desocupa, lo ocupa y no se destruye (DontDestroyOnLoad)
        {
            UNIQUESYSTEM = this;
            DontDestroyOnLoad(gameObject);
        }
        else //sino, el objeto muere y no recibe el "trono"
        {
            Destroy(this.gameObject);
            
        }
    }
    //private IEnumerator EscribirFrase()
    //{
    //
    //}

    public void interactDialoge()
    {
       // NPCTransformCamera.SetPositionAndRotation(camerapoint.transform.position, camerapoint.transform.rotation);
        PanelDeConversacion.SetActive(true);
        textoDialogo.SetText("Hola");
    }
    public void escribirFrase()
    {

    }
    public void siguienteFrase()//Para poder ejecutar este m�todo, tiene que ser p�blico para que el bot�n del di�logo lo ejecute
    {
        
    }

    public void FinishDIalogue()
    {
        PanelDeConversacion.SetActive(true);
        
    }
}
