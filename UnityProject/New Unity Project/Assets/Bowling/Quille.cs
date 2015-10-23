using UnityEngine;
using System.Collections;

public class Quille : MonoBehaviour {

    private int collisionController;

	// Use this for initialization
	void Start () {
        collisionController = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.up.y < 0.3f) {
            //ScoreManager.GetComponent<ScoreManager>().scoreIncrement();
        }
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Clong");
        AudioSource audio = GetComponent<AudioSource>();
        if (audio)
        {
            audio.Play();
            audio.volume = Mathf.Min(collision.relativeVelocity.magnitude / 10.0f, 1.0f);
            
        }
    }
}
