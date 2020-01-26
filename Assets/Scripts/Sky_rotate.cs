using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*************************************************************************************
 * This script is for rotating the skybox
*************************************************************************************/

public class Sky_rotate : MonoBehaviour {

    public float RotateSpeed = 1.0f;

	void Update () {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
	}
}
