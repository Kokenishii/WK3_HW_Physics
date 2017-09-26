using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScript : MonoBehaviour {
    public Transform newLookAt;
    public Transform newMoveTo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider player)
    {
        if(player.tag == "Player")
        {
            CameraScript myCamera = Camera.main.GetComponent<CameraScript>();
           if(newLookAt!=null) myCamera.lookAt = newLookAt;
            if (newMoveTo != null) myCamera.moveTo = newMoveTo;
        }
    }
}
