using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        CameraWork();

    }

    void CameraWork(){

        Vector3 pos = target.transform.position + new Vector3(0.0f, 1.0f, -10.0f);
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * 2.0f);

        }

}

