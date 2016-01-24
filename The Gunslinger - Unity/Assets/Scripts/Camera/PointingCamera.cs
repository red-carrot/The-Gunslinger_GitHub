using UnityEngine;
using System.Collections;

public class PointingCamera : MonoBehaviour 
{
	public Transform target = null;
	public float veloc = 40.0f;

	Animator _anim;
	float vertical;

	void Start()
	{
		_anim = gameObject.GetComponent<Animator> ();
	}

	void Update ()
	{                
		if(transform.position != target.position)
		{
			transform.LookAt(target);
			transform.Translate(Vector3.forward * Time.deltaTime * veloc);
			//Debug.Log(Mathf.Abs(transform.localPosition.x - target.localPosition.x));
			if(Mathf.Abs(transform.localPosition.x - target.localPosition.x) < 0.01 
			   || Mathf.Abs(transform.localPosition.y - target.localPosition.y) < 0.01 
			   || Mathf.Abs(transform.localPosition.z - target.localPosition.z) < 0.01 )
			{
				transform.position = target.position;
			}
		}
		transform.position = target.position;
		transform.rotation = target.rotation;

		// ---------- RotaCION y

		_anim.SetFloat ("Vertical", vertical);

	}
}
