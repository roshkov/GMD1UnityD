using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{

    float curSpeed ;
    Rigidbody rb;
     Animator anim;

    GameObject player;
    [SerializeField] float jumpForce;

      float t;
    // Start is called before the first frame update
    void Start()
    {
        curSpeed = 10f;
         rb = GetComponent<Rigidbody>();
         player = transform.GetChild (0).gameObject;
         anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        
         //What you can do when you not turning
         if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Turn") )
             {
                   //Horizontal movements
                    float move = Input.GetAxis("Horizontal");
                   if (anim.GetBool("isGrounded")) {
                    anim.SetFloat("Speed", move);
                   }
                    transform.Translate (move * Vector3.right * curSpeed * Time.deltaTime, Space.World);  
                    // if (curSpeed < maxspeed) { curSpeed += acceleration; }

                
                    if (Input.GetKeyDown (KeyCode.Space) && anim.GetBool("isGrounded") ){
                    anim.SetTrigger("Jump"); 
                    anim.SetBool("isGrounded", false);
                    rb.velocity += jumpForce * Vector3.up;
        
    }


             }

      //Turn 180

                //if faced to right and is pressed 'moveLeft' btn or   if faced to left and clicked 'moveright' btn  
                    if ((anim.GetBool("DirectionToRight") == true  && Input.GetAxis("Horizontal") < 0   )  ||
                        (anim.GetBool("DirectionToRight") == false && Input.GetAxis("Horizontal") > 0   )  )
                        {
                             if (anim.GetBool("isGrounded")) {
                                anim.SetTrigger("Turn"); 
                             }
                             else {
                                
                                   

                        
                                    // float currY = player.transform.rotation.y;
                                    // Debug.Log ("curry" + currY);


                                    // if (currY>0) {
                                    // while (currY  > player.transform.rotation.y) {
                                    //     player.transform.RotateAround(transform.position, transform.up, Time.deltaTime * 120f);
                                        
                                    // }
                                    // }

                                 if (player.transform.rotation.y > 0 ) {  
                                        
                                    
                                    turn180inairOne ();
                                    //  player.transform.eulerAngles = Vector3.up * -90;   
                                    //  anim.SetBool("DirectionToRight", false); 
                                 }
                                 else { player.transform.eulerAngles = Vector3.up * 90;     anim.SetBool("DirectionToRight", true); }
                                

                             }
                            
                    }  
                 


            
            



    
    
    }

    public void turn180inairOne () {


            // currentEulerAngles += new Vector3(0, -180, 0);
            // player.transform.eulerAngles = Vector3.up * -90;   
            // player.transform.eulerAngles = currentEulerAngles;
            t += Time.deltaTime/4f;
            transform.position = Vector3.Lerp(startPosition, target, t);
            anim.SetBool("DirectionToRight", false); 

    }

}
