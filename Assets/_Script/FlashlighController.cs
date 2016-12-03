using UnityEngine;
using System.Collections;

public class FlashlighController : MonoBehaviour {

    public Light flashlight;
    public AudioSource pickup;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("flashlight hit");
            
            Destroy(this.gameObject);
            flashlight.enabled = true;

            this.pickup.Play();
        }
    }
}
