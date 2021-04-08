using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public Animator anim;

    public CharacterController controller;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // transform.Translate(-1, 0, 0);
            anim.SetBool("Idle", false);
            anim.SetBool("Walk", true);
        }

        if (!Input.GetKey(KeyCode.LeftArrow))
        {
            //  transform.Translate(0, 0, 0);
            anim.SetBool("Idle", true);
            anim.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Walk", true);
        }

        if (!Input.GetKey(KeyCode.RightArrow))
        {
            //  transform.Translate(0, 0, 0);
            anim.SetBool("Idle", true);
            anim.SetBool("Walk", false);

            if (Input.GetKey(KeyCode.UpArrow))
            {
                anim.SetBool("Idle", false);
                anim.SetBool("Walk", true);
            }

            if (!Input.GetKey(KeyCode.UpArrow))
            {
                //  transform.Translate(0, 0, 0);
                anim.SetBool("Idle", true);
                anim.SetBool("Walk", false);

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    anim.SetBool("Idle", false);
                    anim.SetBool("Walk", true);
                }

                if (!Input.GetKey(KeyCode.DownArrow))
                {
                    //  transform.Translate(0, 0, 0);
                    anim.SetBool("Idle", true);
                    anim.SetBool("Walk", false);


                }
            }
        }
    }
}
