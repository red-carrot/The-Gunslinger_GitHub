#pragma strict
 
var rangoMax = 20.0;
var rangoMin = 10.0;
private var bal:GameObject;
 
function Start()
{
    bal = GameObject.Find("Baliza") as GameObject;
}
 
function Update ()
{
    var dist = Vector3.Distance(transform.position, bal.transform.position);
 
    if(dist > 1)
    {
        var aux = bal.transform.position - transform.position;
        var rotation = Quaternion.LookRotation(aux);
        transform.rotation = rotation;
        transform.Translate(Vector3.forward * 5.0 * Time.deltaTime);
    }
    transform.LookAt(GameObject.FindWithTag("Player").transform);
}