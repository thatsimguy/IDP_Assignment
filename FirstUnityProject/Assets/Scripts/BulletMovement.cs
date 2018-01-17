using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    float movementSpeed = 10;

    [SerializeField]
    ParticleSystem explosion;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.up * movementSpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        //  Debug.Log(other.gameObject.name);
        Health healthScript = other.GetComponent<Health>();

        if (healthScript != null)
        {
            ParticleSystem thisExplosion = Instantiate(explosion, transform.position, Quaternion.identity);
            thisExplosion.Play();
            healthScript.AddHealth(10);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
       // Debug.Log(collision.gameObject.name);
    }
}
