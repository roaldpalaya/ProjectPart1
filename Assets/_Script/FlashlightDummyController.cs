using UnityEngine;
using System.Collections;

public class FlashlightDummyController : MonoBehaviour {
    public AudioSource pickup;
    public GameObject flashlight;
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
            flashlight.SetActive(true);
            Destroy(this.gameObject);


            this.pickup.Play();


        }
    }
}
