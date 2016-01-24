using UnityEngine;
using System.Collections;

public class GunControl : MonoBehaviour 
{
	/*PARA USAR ESTE SCRIPT:
	 Hay que asignar cntrlGun al prefab el Player (con tag) y el script "Gun" al prefab de la pistola.

	 Tengo que crear un empty en la pistola para la punta y emparentar ese GameObjetc a "GunHold"

	 Y para decidir que pistola usar crear el prefab de la pistola y darselo a "StartGun"
	 Es importante añadir el script Gun a la pistola o sino no podre emparentarla a StartGun*/

	//Este script va en el prota

	public Transform GunHold;
	public Gun StartGun;
	Gun EquippedGun;

	void Start ()
	{
		if (StartGun != null)
		{
			GunEquip(StartGun);
		}
	}

	public void GunEquip (Gun gunToEquip)
	{
		if (EquippedGun != null)
		{
			Destroy(EquippedGun.gameObject);
		}
		EquippedGun = Instantiate (gunToEquip, GunHold.position, GunHold.rotation) as Gun;
		EquippedGun.transform.parent = GunHold;
	}

	public void Shoot ()
	{
		if (EquippedGun != null)
		{
			EquippedGun.Shoot();
		}
	}
}
