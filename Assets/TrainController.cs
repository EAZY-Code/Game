using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour {

	public float thrust;
	public Rigidbody rb;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
		StartCoroutine ("moveTrain");
	}

	IEnumerator moveTrain() {
		Debug.Log (Time.time);
		yield return new WaitForSeconds(5);
		Debug.Log (Time.time);
		rb.AddForce(thrust,0, 0, ForceMode.Impulse);
	}
}
