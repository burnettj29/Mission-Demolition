using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {
	static public GameObject POI;

	[Header("Set in Inspector")]
	public float easing = 0.05f;
	public Vector3 minXY = Vector3.zero;

	[Header("Set Dynamically")]
	public float camZ;

	void Awake(){
		camZ = this.transform.position.z;
	}

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate() {
		if (POI == null) return;

		Vector3 destination = POI.transform.position;
		destination.x = Mathf.Max (minXY.x, destination.x);
		destination.x = Mathf.Max (minXY.y, destination.y);

		destination = Vector3.Lerp (transform.position, destination, easing);

		destination.z = camZ;

		transform.position = destination;

		Camera.main.orthographicSize = destination.y + 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
