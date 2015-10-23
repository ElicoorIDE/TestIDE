using UnityEngine;
using System.Collections;

public class CameraBoule: MonoBehaviour {
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - GameObject.Find("BowlingBall").transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = GameObject.Find("BowlingBall").transform.position+offset;
	}
}
