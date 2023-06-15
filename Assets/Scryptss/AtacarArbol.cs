using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

// public class Enemigo : MonoBehaviour
// {
//     public Transform arbol;
//     public float velocidadMovimiento = 2f;
//     public int limiteGolpes = 6;

//     private int golpes = 0;
//     private bool estaMuerto = false;

//     void Update()
//     {
//         if (estaMuerto)
//         {
//             return; // Si el enemigo está muerto, no realiza ninguna acción
//         }

//         // Mueve al enemigo hacia el arbol
//         Vector3 direccion = (arbol.position - transform.position).normalized;
//         transform.Translate(direccion * velocidadMovimiento * Time.deltaTime);

//         // Rotación hacia el arbol (opcional)
//         transform.rotation = Quaternion.LookRotation(Vector3.forward, direccion);

//         // Si el enemigo ha llegado al arbol, realiza un golpe
//         if (Vector3.Distance(transform.position, arbol.position) <= 0.5f)
//         {
//             RealizarGolpe();
//         }
//     }

//     void RealizarGolpe()
//     {
//         golpes++;

//         if (golpes >= limiteGolpes)
//         {
//             // El enemigo está muerto
//             estaMuerto = true;
//             Debug.Log("El enemigo ha sido derrotado");
//             // Aquí puedes agregar lógica adicional para mostrar una animación de muerte o realizar otras acciones.

//             Destroy(gameObject); // Elimina el objeto del enemigo de la escena
//         }
//         else
//         {
//             Debug.Log("El enemigo ha realizado un golpe");
//             // Aquí puedes agregar lógica adicional para mostrar una animación de golpe, reproducir un sonido, etc.
            
//         }
//     }
// }
