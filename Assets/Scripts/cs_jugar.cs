using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cs_jugar : MonoBehaviour
{
   public void jugar() {
	   SceneManager.LoadScene("Nivel");
   }

   public void salir() {
	   Application.Quit();
   }
}
