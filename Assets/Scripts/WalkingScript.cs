using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScript : MonoBehaviour {

	public float speed = 0.05f;

	public float start;
	public float end;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		//this.transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * speed);
		//this.transform.Translate(direction * (Time.deltaTime*(distance/time)));
		if(this.transform.localPosition.z > end || this.transform.localPosition.z < start){
			if(this.transform.localPosition.z > end){
				this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, end);
			}
			if(this.transform.localPosition.z < start){
				this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, start);
			}
			transform.Rotate(0, 180, 0);
		}
		this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

	}
}
