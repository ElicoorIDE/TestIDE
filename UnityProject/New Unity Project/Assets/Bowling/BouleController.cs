using UnityEngine;
using System.Collections;

public class BouleController: MonoBehaviour {

    public float fwdSpd = 25;
    public float rgtSpd = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Axe vertical " + Input.GetAxis("Vertical"));
        GetComponent<Rigidbody>().AddForce(Vector3.forward*Input.GetAxis("Vertical")*fwdSpd);
        GetComponent<Rigidbody>().AddForce(Vector3.right * Input.GetAxis("Horizontal")*rgtSpd);
        AudioSource audio = GetComponent<AudioSource>();
        if (audio && GetComponent<Rigidbody>().velocity.z>20)
        {
            audio.Play();
            

        }
    }
}
