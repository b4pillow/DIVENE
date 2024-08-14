using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Combos : MonoBehaviour
{
    public Animator anim;

    public int combo = 0;

    public bool attacking = false;

    public AudioSource audio;

    public AudioClip[] sonido;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    public void Start_Combo()
    {
        attacking = false;
        if (combo < 2)
        {
            combo++;
        }
    }

    public void Finish_Ani()
    {
        attacking = false;
        combo = 0;
        anim.ResetTrigger("0");
        anim.ResetTrigger("1");
    }

    public void Combo()
    {
        if (Input.GetMouseButtonDown(0) && !attacking);
        {
            attacking = true;
            anim.SetTrigger(combo.ToString());
            //audio.clip = sonido[combo];
            //audio.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Combo();
    }
}
