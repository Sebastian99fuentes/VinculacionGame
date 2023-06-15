using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckArbol : MonoBehaviour
{
    public static bool colArbol;

         private void OnCollisionEnter2D(Collider2D collision)
         {
            if(collision.gameObject.tag =="TagArbol") colArbol=true;

         }

          private void OntriggerExit2D(Collider2D collision)
         {
            if(collision.gameObject.tag =="TagArbol") colArbol=false;

         }
}
