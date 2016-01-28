using UnityEngine;
using System.Collections;

public class MovieTexture : MonoBehaviour 
{
	void Start ()
	{
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
	}
}