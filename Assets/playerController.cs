using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//上キーを押されたら前へ進む
		if (Input.GetKey("up")){
			transform.position += transform.forward * 0.1f;
		}

		//右キーを押されたら右に向く
		if (Input.GetKey("right")){
			transform.Rotate(0, 5, 0);
		}

		//左キーを押されたら左に向く
		if (Input.GetKey("left")){
			transform.Rotate(0, -5, 0);
		}
	}
}
