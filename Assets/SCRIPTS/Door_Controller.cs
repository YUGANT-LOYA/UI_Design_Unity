using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
	public Vector3 centre;
	public float radius;
	public float speed = 0.2f;
	public GameObject P;
	public Vector3 targetPos = new Vector3(0,1,0);
	void Start()
	{
		centre = transform.position;
	}
	
    void Update()
    {
	   
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("Player Entered");
			transform.position = targetPos * speed * Time.deltaTime;
		}
	}
	private void OnTriggerExit(Collider other)
	{
		Debug.Log("Player Exit");
		transform.position = centre;
	}

	/*void OnDrawGizmos()
    {
	    Gizmos.DrawSphere(centre, radius);

	    if (GameObject.Find("Player"))//GameObject.FindWithTag("Player"))
	    {
		    transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
	    }
	}*/


}
