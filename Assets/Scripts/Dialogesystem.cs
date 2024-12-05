using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogesystem : MonoBehaviour
{
    [SerializeField]GameObject PanelDeConversacion;
    //RECUERDA: SIGNLE-TON SE ASEGURA DE QUE ESTA SEA LA UNICA INSTANCIA DEL ESTE SCRIPT Y QUE PUEDAS LLAMAR AL SCRIPT EN CUALQUIER LUGAR. SOLO UNA INSTANCIA PUEDE TENER SINGLE-TON(trono)
    public static Dialogesystem UNIQUESYSTEM;
    [SerializeField]TextMeshPro textoDialogo;
    bool writing;
    int ActualIndex;

    private void Awake()
    {
        if (UNIQUESYSTEM == null)//si el signle-ton(el "trono" está desocupa, lo ocupa y no se destruye (DontDestroyOnLoad)
        {
            UNIQUESYSTEM = this;
            DontDestroyOnLoad(gameObject);
        }
        else //sino, el objeto muere y no recibe el "trono"
        {
            Destroy(this.gameObject);
        }
    }

    public void interactDialoge()
    {
        PanelDeConversacion.SetActive(true);
        textoDialogo.SetText("Hola");
    }
    public void escribirFrase()
    {

    }
    public void NextPhrase()
    {

    }

    public void FinishDIalogue()
    {
        PanelDeConversacion.SetActive(true);
        
    }
}
