using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {

    [SerializeField]
    GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
    public void BtnAFire()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
	// Update is called once per frame
	void Update () {
        // When mouse button is pressed
        /*
        if (Input.GetMouseButtonDown(0))
        {
            //create a bullet
            Instantiate(bullet, transform.position, transform.rotation);
        }*/

    }
}
