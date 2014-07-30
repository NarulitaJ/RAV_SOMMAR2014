using UnityEngine;
using System.Collections;

public class TestCamera : MonoBehaviour {

	public GameObject targetLookAt;
	public Vector3 _offset;

	// Use this for initialization
	void Start () {
	
		transform.position = targetLookAt.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt (targetLookAt.transform);
	//	transform.position = targetLookAt.transform.position;
	}
}
