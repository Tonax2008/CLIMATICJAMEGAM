using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_basura1 : MonoBehaviour
{

   //public Score score;
   private void OnCollisionEnter2D(Collision2D other)
 {
       
   if (other.gameObject.tag == "Player")
 

  { 
      
     Destroy (this.gameObject);
     Debug.Log("destrucciin");
     Score.numberOfCoins += 1; 
       
  }
 }

 private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //FindObjectOfType<AudioManager>().PlaySound("PickUpCoin");
            Debug.Log("Sea agrego una moneda");
            Score.numberOfCoins += 1;
            Destroy(gameObject);

        }
    }
}
