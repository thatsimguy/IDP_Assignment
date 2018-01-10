using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyScript : MonoBehaviour {

    [SerializeField]
    GameObject joyObj;

    [SerializeField]
    Camera UICamera;

    Image joyBG;
    Image joyFG;

    public Vector3 direction;
    Vector3 startPosition;


	// Use this for initialization
	void Start () {
        joyBG = joyObj.GetComponent<Image>();
        joyFG = joyBG.transform.GetChild(0).GetComponent<Image>();

	}
	

    public void StartPosition()
    {
#if UNITY_EDITOR
        startPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);

#elif UNITY_ANDROID || UNITY_IOS
        Touch mytouch = Input.GetTouch(0);
        startPosition = new Vector3(mytouch.position.x, mytouch.position.y);
#else
        startPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
#endif
    }


    public void Dragging()
    {

#if UNITY_EDITOR
        Vector2 tempPos = new Vector2(Input.mousePosition.x - startPosition.x, Input.mousePosition.y - startPosition.y);

#elif UNITY_ANDROID || UNITY_IOS
        Touch mytouch = Input.GetTouch(0);
        Vector2 tempPos = new Vector2(mytouch.position.x - startPosition.x, mytouch.position. y- startPosition.y);

#else
        Vector2 tempPos = new Vector2(Input.mousePosition.x - startPosition.x, Input.mousePosition. y- startPosition.y);

#endif
        Vector2 clampPos = Vector2.ClampMagnitude(tempPos, 50);
        Vector3 newPosition = new Vector3(clampPos.x, clampPos.y, 1);
        
        joyFG.rectTransform.localPosition = newPosition;
        direction = joyFG.rectTransform.localPosition;

    }


    public void StopDrag()
    {
        joyFG.rectTransform.localPosition = new Vector3(0,0,1);
    }


	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if (Application.platform == RuntimePlatform.Android)
                Application.Quit();
        }

	}
}
