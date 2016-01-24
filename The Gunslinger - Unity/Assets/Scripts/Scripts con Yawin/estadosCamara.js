#pragma strict
 
private var estado = false;
private var camara:GameObject;
 
function Start()
{
    camara = GameObject.FindWithTag("MainCamera") as GameObject;
}
 
function Update()
{
    if(Input.GetKey(KeyCode.KeypadEnter))
    {
        estado = !estado;
        gestionaCamara();
    }
}
 
function gestionaCamara()
{
    var cC = camara.GetComponent.<camaraCerca>();
    var oC = camara.GetComponent.<orbitController>();
 
    cC.enabled = estado;
    oC.enabled = !estado;
}