using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
	public Vector3 centre;
	public Vector3 targetpos;
	public GameObject[] door;
	//public Collider collider;
    void Start()
    {
	    centre = transform.position;
		
	    //collider = GetComponentInChildren<Collider>();

		if (GameObject.FindGameObjectWithTag("Door"))
		{
			print("Door found ");
		}

	}

    void Update()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
	    targetpos = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
	    print("Vector3 : " + transform.position);
	    transform.position = targetpos;
    }

	private void OnTriggerExit(Collider other)
	{
		print("Vector3 : " + transform.position);
		transform.position = centre;
	}
}
