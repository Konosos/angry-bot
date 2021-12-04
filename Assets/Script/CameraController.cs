using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    MyBird[] _myBird;
    [SerializeField] private Transform transformMyBird;
	// Use this for initialization
	void Start ()
    {
        //transformMyBird.GetComponent<Transform>().position.x
	}
	
	// Update is called once per frame
	void Update ()
    {
        //GetComponent<Transform>().position = new Vector3(transformMyBird.GetComponent<Transform>().position.x, transformMyBird.GetComponent<Transform>().position.y,transform.position.z);
		GetComponent<Camera>().orthographicSize=9;
	}
}
