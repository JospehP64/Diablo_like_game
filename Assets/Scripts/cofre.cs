using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cofre : MonoBehaviour
{
    Outline colorOutline;
    [SerializeField]Texture2D SecondaryCursorTexture;
    [SerializeField]Texture2D DefaultCursorTexture;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void Awake()//comienza antes del start. Solo se ejecuta una vez independientemente del script
    {
        colorOutline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        Cursor.SetCursor(SecondaryCursorTexture, Vector2.zero, CursorMode.Auto);
        colorOutline.enabled = true; 
    }
    private void OnMouseExit()
    {
        Cursor.SetCursor(DefaultCursorTexture, Vector2.zero, CursorMode.Auto);
        colorOutline.enabled = false;
    }
}
