using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avtiv_Panel : MonoBehaviour
{
   public GameObject Panel;
    
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
