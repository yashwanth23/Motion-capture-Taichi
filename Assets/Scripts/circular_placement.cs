using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************************************************************************
 * Placing the clones of characters in a circular fashion
 * Animation delay is given to each character 
 *****************************************************************************************************************************************/

public class circular_placement : MonoBehaviour {

    public GameObject character;
    public int radius;
    public float anim_delay;
    private GameObject[] duplicates;
    private int count = 0;

	void Start () {

        //Creating 12 clones of the main character
        duplicates = new GameObject[12];

        //Vector3 char_rot = character.transform.eulerAngles;
        for (int i = 0; i < 12; i++)
        {
            //Arranging the clones equi-angled 
            float angle = 30 * i * Mathf.PI / 180;

            //Converting polar coordinates to cartesian coordinates
            float x = radius * Mathf.Sin(angle);
            float z = radius * Mathf.Cos(angle);
            Vector3 pos = new Vector3(x + character.transform.position.x, character.transform.position.y, z + character.transform.position.z);

            //Vector3 rot = new Vector3(0, 30 * i, 0);

            //Instantiating the clones equi-angled in a circular fashion while also orienting each of them outwards
            duplicates[i] = Instantiate(character, pos, Quaternion.identity);
            duplicates[i].transform.Rotate(0, 30 * i, 0, Space.Self);
            duplicates[i].GetComponent<Animator>().enabled = false;
        }

    }

    private void Update()
    {
        count++;
        //Debug.Log(count);

        //This is for animation delay
        if(count%20 == 0 && count <= 20*12)
        {
            int val = count / 20 - 1;
            Debug.Log(val);
            duplicates[val].GetComponent<Animator>().enabled = true;

        }
    }
    
}
