using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   public float timeStart = 90;
   public Text textBox;
   public GameObject Panel;

   void Start(){
       textBox.text = timeStart.ToString("0");
   }
   void Update (){
       timeStart -= Time.deltaTime;
       textBox.text = Mathf.Round(timeStart).ToString("0");
       
       /*AL FINALIZAR CONTADOR */
       if (timeStart <= 0)
       {
           
        
        Time.timeScale=0;
        timeStart=0;
        //OpenPanel();
       }
   }
   

    public void OpenPanel()
    {
        if (Panel != null)
        {
        
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            Debug.Log("Activar imagen");

        }
    } 
}