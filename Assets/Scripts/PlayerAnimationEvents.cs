using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    enemy Enemigos;
    [SerializeField]player MainPlAYER;
    Animator Mainanimator;
    private void Awake()//comienzo de todo
    {
        MainPlAYER = FindAnyObjectByType<player>();
        Mainanimator = GetComponent<Animator>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Enemigos = FindAnyObjectByType<enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JugadorAtacando()
    {
        Mainanimator.SetBool("atacar", true);
        Enemigos.vida--;
    }
    public void JugadorDejaDeAtacar()
    {
        Mainanimator.SetBool("atacar", false);
    }
}
