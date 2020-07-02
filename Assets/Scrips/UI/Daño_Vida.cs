using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano_Vida : MonoBehaviour
{

    public float currentHealth;
    public Bar_Vida bar_vida;

     void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Damage(20);
		}
		
    }

	public void Damage(float damage)
	{
		currentHealth -= damage;

		bar_vida.Score_Saludable (damage);
	}
}
