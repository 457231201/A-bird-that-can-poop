using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class class_work : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetTrigger("fly");
    }
}
