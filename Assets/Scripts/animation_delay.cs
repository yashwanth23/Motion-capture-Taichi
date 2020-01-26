using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************************************************************************
 * This script is for starting the animation with some delay
 ***********************************************************************************************************************/

public class animation_delay : MonoBehaviour {

    public float anim_delay;
    public GameObject shadow;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(DelayedAnimation());
        
    }

    IEnumerator DelayedAnimation()
    {
        //Set the gameobject active after some delay
        yield return new WaitForSeconds(anim_delay);
        shadow.SetActive(true);
    }
}
