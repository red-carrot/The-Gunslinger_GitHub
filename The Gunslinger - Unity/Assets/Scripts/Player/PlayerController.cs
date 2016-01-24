using UnityEngine;
using System.Collections;

[RequireComponent (typeof (GunControl))]

public class PlayerController : MonoBehaviour 
{
	#region Animator de antes (inservible)

	/*Animator anim;
	public bool bJump;
	public bool bSlide;
	public bool bAim;
	public float speed;

	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
	}

	void Update ()
	{
		anim.SetBool("Jump", bJump);
		anim.SetBool("Voltereta", bSlide);
		anim.SetBool("Aim", bAim);
		anim.SetFloat("speed", speed);


		// Movimiento

		// Salto
		if (Input.GetKey("space"))
		{
			print ("SAAALTO YEY!!");
			bJump=true;
		}
		else
		{
			bJump=false;
			bSlide=false;
		}

		// Voltereta
		if (Input.GetKey("left shift"))
		{
			print ("No me pegas, payaso :D");
			bSlide=true;
		}

		// Aim
		if (Input.GetKeyDown("left alt"))
		{
			bAim=true;
			print ("Aim ON!!");
			//speed=0.2f;
		}
		else if (Input.GetKeyUp("mouse 1"))
		{
			bAim=false;
		}
	}*/
	#endregion

#region Variables publicas y privadas
	
	public float _forward;
	public bool _aim;
	//public Camera aimCamera;

	Animator _anim;
	float _fAim;
	GunControl _gunControl;

#endregion


#region Funciones 

	void Start()
	{
		_anim = gameObject.GetComponent<Animator>() as Animator;
		_gunControl = GetComponent<GunControl> ();
		//_AnimCamera = aimCamera.GetComponent<Animator>() as Animator;
	}

	void FixedUpdate()
	{
		_anim.SetBool("Aim", _aim);
		_anim.SetFloat ("FAim", _fAim);
		//_AnimCamera.SetBool("cAim", _cAim);
		//_anim.SetFloat("Forward", _forward);


		
		if (Input.GetButton("Aim"))
		{
			if (Input.GetButton("Fire"))
			{
				_gunControl.Shoot();
				print("PIUMPIM!!!");
			}

			_aim=true;
			_fAim=1.0f;

			//_cAim=true;

			print("Aim ON!!");
			//_Aim(0.1f);


		}
		else if (Input.GetButtonUp("Aim"))
		{
			_aim=false;

			//_cAim=true;

			//_fAim=0f;
			print("Aim OFF");
		}
	}

	public void _Aim(float speed)
	{
		//_forward = speed;
	}

#endregion


}
