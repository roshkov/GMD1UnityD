using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumanjiScript : MonoBehaviour
{
    Animator anim;
    int jumpHash = Animator.StringToHash("Jump");
    int runStateHash = Animator.StringToHash ("Base Layer.Run");

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", move);


        // AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        // if(Input.GetKeyDown(KeyCode.Space) && stateInfo.nameHash == runStateHash) {
              if(Input.GetKeyDown("space")) {
            anim.SetTrigger (jumpHash);
        }

    }
}
