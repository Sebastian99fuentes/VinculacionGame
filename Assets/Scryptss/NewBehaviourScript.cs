using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidad = 5f;
    public float speed = 1f;
    public float distance = 0.2f;

    private float positionLeft;
    private float positionRight;
    private bool isMovingRight = true;

    public SpriteRenderer spriteR;

     public bool colArbol=false;
    // Start is called before the first frame update
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();   //Para asignar el sprite desde el código
        positionLeft = gameObject.transform.position.x - distance;
        positionRight = gameObject.transform.position.x + distance;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (isMovingRight)
        {//Mueve el componente
            gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if(transform.position.x >= positionRight)
        {
            isMovingRight = false;
            spriteR.flipX= false;
        }
           
        if(transform.position.x <= positionLeft)
        {
            isMovingRight = true;
            spriteR.flipX = true;//Dar la vuelta al sprite
        }
            
    
    }
    void OnCollisionEnter2D(Collision2D collision){
        
          Debug.Log("toco arbol");
        
    }
}
