﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootMotionSwitch : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnAnimatorMove()
    {
        
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
         
          // APPLY DEFAULT ROOT MOTION, ONLY WHEN IN THESE ANIMATION STATES
        
            if (stateInfo.IsName("Turn")  || stateInfo.IsName("TurnRunning") )
             {
             anim.ApplyBuiltinRootMotion();
             }
       
        
        
        
        
        
        
        // if (animator)
        // {
        //     Vector3 newPosition = transform.position;
        //     newPosition.x += animator.GetFloat("Runspeed") * Time.deltaTime;
        //     transform.position = newPosition;
        // }
    }


}
