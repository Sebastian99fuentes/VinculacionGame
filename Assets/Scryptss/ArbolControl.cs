using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolControl : MonoBehaviour
{
    public Animator animator; 
    public bool IsALife=true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter2D(Collider2D   collision)
    {
        
            animator.SetBool("TriggerArbol",true);
            Debug.Log("toco");

    

    }
}
