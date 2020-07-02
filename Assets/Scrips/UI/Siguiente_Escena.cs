using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Siguiente_Escena : MonoBehaviour
{
     public void  cambiarsiguiente (string nombreescena)
     {
         SceneManager.LoadScene(nombreescena);
         //Debug.Log("C   ambio de escena");

     }
               
    
}
