using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class rain : MonoBehaviour
{
    //float timer=0;
    public GameObject raindrop;
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        Input.multiTouchEnabled = true;
        //Instantiate(raindrop,bird.transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
       //timer+=Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
        Vector3 pos=Input.mousePosition;
        if(pos.x>Screen.width/2&&pos.y>Screen.height/2.5f)
            {
               //timer=0
               Instantiate(raindrop,bird.transform.position+Vector3.down*5,Quaternion.identity);
            }
        
        }
    
    }
    }
