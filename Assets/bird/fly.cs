using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class fly : MonoBehaviour
{
 
     public Joystick joystick;
     public Joystick joystick_2;
  private CharacterController bird;
    // Start is called before the first frame update
   float timer=0;
   float timer2=0;
   bool up=false;
   bool move=false;
    void Start()
    {
      bird=GetComponent<CharacterController>();
       
    }

    // Update is called once per frame
    void Update()
    {
     
    //float horizontal = Input.GetAxis("Horizontal");
   // float vertical = Input.GetAxis("Vertical");
    float horizontal = joystick.Horizontal;
    float vertical = joystick.Vertical;
    float hight = joystick_2.Vertical;
     Vector3 dir=new Vector3(horizontal,0,vertical);
     Vector3 dir2=new Vector3(0,hight,0);
     if(dir+dir2!=Vector3.zero)
          {
            //float timer=0;
            timer2=0;
            timer+=Time.deltaTime;
            GetComponent<Animator>().SetBool("fly_start",true);
            GetComponent<Animator>().SetBool("fly_end",false);
            transform.rotation=Quaternion.LookRotation(dir);
            if (dir!=Vector3.zero)
            {
                    if (timer >=1 && timer<2 )
                  {
                    up=false;
                    transform.Translate(Vector3.forward*Time.deltaTime*8);
                    transform.Translate(Vector3.up*Time.deltaTime*3);
                  }
                  else if (timer >=2)
                  {
                    transform.Translate(Vector3.forward*Time.deltaTime*8);
                    transform.Translate(dir2*0.05f);
                    up=true;
            }
            }
            else
            {
                    if (timer >=1 && timer<2 && move==true)
                    {
                    up=false;
                    //transform.Translate(Vector3.forward*Time.deltaTime*8);
                    transform.Translate(Vector3.up*Time.deltaTime*3);
                  }
                  else if (timer >=2)
                    {
                   // transform.Translate(Vector3.forward*Time.deltaTime*8);
                    transform.Translate(dir2*0.05f);
                    up=true;
                    }
            }
            
            
            }
        
    else if (dir+dir2==Vector3.zero)
        {  
          GetComponent<Animator>().SetBool("fly_end",true);
          GetComponent<Animator>().SetBool("fly_start",false);
          timer=0;
          timer2+=Time.deltaTime;
          if (timer2 >=0 && timer2 <=1 && up == true )
          {
           
            transform.Translate(Vector3.down*Time.deltaTime*3);
          }
        }
    
    }
}
