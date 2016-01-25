using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(SylviaMuerto))]

public class SylviaControl : MonoBehaviour 
{
	#region Variables

	NavMeshAgent huir;

	GameObject gHuir;

	public float DistanciaMirar;
	public float DistanciaHuir;
	public float DistanciaGritar;

	// Animaciones
	Animator _anim;
	bool bHuir;
	bool bGritar;

	#endregion


	#region Funciones Start y Update

	void Start()
	{
		// Huir
		huir = gameObject.GetComponent<NavMeshAgent>();

		gHuir = GameObject.FindWithTag("Player");
		bHuir = false;

		// Animaciones

		_anim = GetComponent<Animator>();
	}

	void Update()
	{
		// Definir las variables de la animacion

		_anim.SetBool("huir", bHuir);

		// Huir
		float fDistanciaConProta;

		fDistanciaConProta = Vector3.Distance(gameObject.transform.position, gHuir.transform.position);

		if (fDistanciaConProta < DistanciaMirar)
		{
			gameObject.transform.LookAt (gHuir.transform.position);
		}
		if (fDistanciaConProta < DistanciaHuir)
		{
			huir.SetDestination(gHuir.transform.position);
			print("Te sigo (L)");
			bHuir = true;

			_anim.SetBool ("gritar", bGritar);

			if (fDistanciaConProta < DistanciaGritar)
			{
				bGritar = true;
			}
			else{
				bGritar=false;
			}
		}
		else
		{
			bHuir = false;
		}
	}

	#endregion


	#region Colisiones

	#endregion
}
