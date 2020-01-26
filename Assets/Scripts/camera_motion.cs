using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*************************************************************************************************************************************************
 * This script is for creating a path for camera motion
 * The script starts of with zooming in to the subject and at a certain distance it revolves around the subject while facing it
 ************************************************************************************************************************************************/

public class camera_motion : MonoBehaviour {
    public GameObject reference;
    public float speed, rotate_speed;

	void Update () {
        //Calculating the distance between the camera and the subject
        float dist = Vector3.Distance(reference.transform.position, transform.position);

        Debug.Log(dist);
        if(dist > 25)
        {
            //As long is the distance is greater than 25 the camera moves forward facing the subject
            transform.position = Vector3.MoveTowards(transform.position, reference.transform.position, speed * Time.deltaTime);
        }
        else
        {
            //When the distance is 25 the camera starts to rotate around the subject while always facing the subject
            transform.RotateAround(reference.transform.position, Vector3.up, rotate_speed * Time.deltaTime);
            transform.LookAt(reference.transform);
        }
        
        
	}
}
