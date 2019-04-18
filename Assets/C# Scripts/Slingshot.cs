using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {
	public GameObject prefabProjectile;
	public GameObject launchPoint;
	public Vector3    launchPos;
	public GameObject projectile;
	public bool       aimingMode;

	void Awake(){
		Transform launchPointTrans = transform.Find ("Launch Point");
		launchPoint = launchPointTrans.gameObject;
		launchPoint.SetActive (false);
		launchPos = launchPointTrans.position;
	}

	void onMouseEnter(){
		//print ("Slingshot:OnMouseEnter()");
		launchPoint.SetActive (true);
	}

	void onMouseExit(){
		//print ("Slingshot:OnMouseExit()");
		launchPoint.SetActive(false);
	}

	void OnMouseDown(){
		aimingMode = true;
		projectile = Instantiate (prefabProjectile) as GameObject;
		projectile.transform.position = launchPos;
		projectile.GetComponent<Rigidbody> ().isKinematic = true;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
