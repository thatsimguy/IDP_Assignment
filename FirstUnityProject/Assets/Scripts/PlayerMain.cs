using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 10;

    [SerializeField]
    float rotateSpeed = 60;

    [SerializeField]
    GameObject UIObj;

    JoyScript targetScript;

    Vector3 yAxis;

    void Awake()
    {
        Debug.Log("Awake");
    }
	// Use this for initialization
	void Start()
    {
        Debug.Log("Start");
        yAxis = new Vector3(0, 1, 0);
        targetScript = UIObj.GetComponent<JoyScript>();
    }

    void Init()
    {

    }
	
	// Update is called once per frame
	void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }

        Vector3 targetDir = targetScript.direction;
        Debug.Log(targetDir);

        Vector3 newDir = Vector3.RotateTowards(transform.forward, 
                            new Vector3(targetDir.x, 0.0f, targetDir.y), 
                             Time.deltaTime * rotateSpeed, 0.0F);


        transform.rotation = Quaternion.LookRotation(newDir);


    }

    void FixedUpdate()
    {
    }
}