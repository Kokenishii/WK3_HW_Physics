using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Generator : MonoBehaviour {
  
    public GameObject myObject;
    public float dominoNumber; 
    // Use this for initialization
    void Start () {
		for(int i = 0;i<dominoNumber;i++)
        {
            GameObject newObject = Instantiate(myObject, new Vector3(0, 0, 0),Quaternion.Euler(0,i*360/dominoNumber,0));
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
