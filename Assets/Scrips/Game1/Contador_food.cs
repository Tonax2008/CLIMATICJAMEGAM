using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador_food : MonoBehaviour
{
    private GameObject pelota;
    private GameObject saludable;
    private int Score_carn;
    private int Score_vega;
    public Bar_Vida bar_vida;
    private bool tipo;

    private void OnCollisionEnter2D(Collision2D other)
    
        
    
    {
        //Debug.Log("hit detected");

         if (other.gameObject.tag == "Pelota")
        {
            pelota= GameObject.FindGameObjectWithTag ("Pelota");

            Destroy(pelota);
            //Debug.Log("pelota");
            Carne(15);
    
        }

        else
        {
            saludable= GameObject.FindGameObjectWithTag ("Eco");

            Destroy(saludable);
            //Debug.Log("Eco");
            Vega(10);

        }
        
    }

    void Carne(int damage)
	{
		Score_carn = damage + damage;
		
	}

    void Vega (int damage2)

    {

		Score_vega = damage2+ damage2;
        
        //if (damage2)
        //
        //    tipo=true;
          //  bar_vida.Score_Saludable(tipo);
      //  }
		

	}


    

}
