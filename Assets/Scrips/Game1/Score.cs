using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    
   
    public  bool gameOver ;
    //public GameObject MarcadorFin;
    public GameObject Panel;
    public static bool isGameStarted;
    public GameObject startingText;
    public static float numberOfCoins;
    public Text Marcador;
    public float timeStart = 90;
    public Text textBox;
    public Text time;
    public Dano_Vida dano_vida;
   
   //public GameObject Panel;

    

    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        isGameStarted = false;
        numberOfCoins = 0;
        time.text = timeStart.ToString("0");
    }


    // Update is called once per frame
    void LateUpdate()
    {
        

        Marcador.text = " " + numberOfCoins;
        timeStart -= Time.deltaTime;
        
       time.text = Mathf.Round(timeStart).ToString("0");
        textBox.text =  " "+ numberOfCoins;
       

       
       /*AL FINALIZAR CONTADOR */
       if (timeStart <= 0)
       {
           
        Panel.SetActive(true);
        Time.timeScale=0;
        timeStart=0;
        
       }
       
        //Debug.Log("Se te va agregar una moneda");
        //if (SwipeManager.tap  && !isGameStarted)
        //{
        //   isGameStarted = true;
        //  Destroy(startingText);
        // }

    }

    public void FinJuego()
    {
        //gameOver=false
        
        
        if (Panel != null)
        {
        
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            Debug.Log("Activar imagen");

        }

        dano_vida.Damage(numberOfCoins);



        //Time.timeScale = 0;
        Debug.Log("Activando fin del juego");
       // SceneManager.LoadScene("LVL1");
    }

}
