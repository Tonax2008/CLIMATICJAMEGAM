using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_basura : MonoBehaviour
{
    public GameObject pelota;
    public GameObject saludable;

    private void OnTriggerEnter2D(Collider2D other)
    {
            //Debug.Log("hit detected");

         if (other.gameObject.tag == "Pelota")
            {
            pelota= GameObject.FindGameObjectWithTag ("Pelota");

            Destroy(pelota);
            //Debug.Log("pelota");
            
            }
        
    

        else
        {
            saludable= GameObject.FindGameObjectWithTag ("Eco");

            Destroy(saludable);
            //Debug.Log("Eco");
        }
    }
   
}
