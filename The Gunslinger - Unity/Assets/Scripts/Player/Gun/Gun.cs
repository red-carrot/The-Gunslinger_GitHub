using UnityEngine;
using System.Collections;

//Es importante que este script este en el prefab de la pistola o no funcionara

public class Gun : MonoBehaviour 
	/*Desde aqui controlo la cadencia de tiro y la velocidad de las balas*/

{
	public Transform punta;
	public Proyectil proyectil;
	public float msEntreDisparo = 200;
	public float velBala = 35;

	float nextShootTime;

	public void Shoot ()
	{
		if (Time.time > nextShootTime)
		{
			nextShootTime = Time.time + msEntreDisparo / 1000;
			Proyectil newProyectil = Instantiate(proyectil, punta.position, punta.rotation) as Proyectil;
			newProyectil.SetSpeed (velBala);
		}
	}
}
