using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar_Vida : MonoBehaviour
{
    Image barvida;
    float maxvida = 100;
    public static float corazon;
    public float currentHealth;
    private bool score;
    public float vida =100;
    

    private void Start() 
    {
        barvida=GetComponent <Image>();
        corazon =maxvida;

    }



    private void Update() 
    {
        barvida.fillAmount = vida;

    }

    public void Score_Saludable(float score)
    {
        currentHealth= maxvida - score;
        maxvida-=score; 
        vida=currentHealth / 100;



        
        Debug.Log(vida);
        


        
    }



    

}
