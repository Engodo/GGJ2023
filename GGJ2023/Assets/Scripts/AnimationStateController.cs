using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{


    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update() 
    {
        Move();
        GetInput();    
    }
    void Move()
    {

        if ((Input.GetKey(KeyCode.W))||(Input.GetKey(KeyCode.S))|| (Input.GetKey(KeyCode.A))|| (Input.GetKey(KeyCode.D)))
        {
            if (anim.GetBool("attacking") == true)
            {
                return;
            }
            else if (anim.GetBool("attacking") == false)
            {
                anim.SetBool("running", true);
                anim.SetInteger("Condition", 1);
            }
        }
            if(Input.GetKeyUp (KeyCode.W)) 
            {
                anim.SetBool("running", false);
                anim.SetInteger("Condition", 0);
            }
    }

    void GetInput()
    {
        if(Input.GetMouseButtonDown (0))
        {
            if (anim.GetBool("running") == true)
            {
                anim.SetBool("running", false);
                anim.SetInteger("Condition", 0);
            }
             if (anim.GetBool("running") == false)
            {

                Attacking();
       
            }
        }
    }

    void Attacking()
    {
        StartCoroutine(AttackRoutine());
    }
    IEnumerator AttackRoutine() 
    {
        anim.SetBool("attacking", true);
        anim.SetInteger("Condition", 2);
        yield return new WaitForSeconds(1);
        anim.SetInteger("Condition", 0);
        anim.SetBool("attacking", false);
    }
}