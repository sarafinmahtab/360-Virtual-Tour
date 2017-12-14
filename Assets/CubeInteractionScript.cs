using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteractionScript : MonoBehaviour {

	public GameObject gameObjectForCube;
	public GameObject gameObjectForCube2;
//	Vector3 tempPosi;
	Vector3 tempPosi, tempPosi2;

	// Use this for initialization
	void Start () {
		tempPosi = gameObjectForCube.transform.position;
		tempPosi2 = tempPosi;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PointerDown() {
//		Camera.main.transform.Translate(300,0,0);
//		transform.position = new Vector3 (300, 0, 0);
		Debug.Log ("Pointer Down");

		tempPosi.x = 300f;

		gameObjectForCube.transform.position = tempPosi;
		gameObjectForCube2.transform.position = tempPosi2;
		transform.position = tempPosi;
	}
}
