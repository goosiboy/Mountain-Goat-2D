using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudLocations : MonoBehaviour {

    private GameObject cloud;
    private float posX;
    private float posY;
    private List<GameObject> cloudArray = new List<GameObject>();
    private int amountOfClouds = 20;

    private void Awake()
    {
        cloud = GameObject.Find("Cloud");

        for (int i = 0; i < amountOfClouds; i++)
        {

        }

    }

    // Use this for initialization
    void Start () {

        

        posX = cloud.transform.position.x;
        posY = cloud.transform.position.y;

        print("posX: " + posX);
        print("posY: " + posY);


    }

    // Update is called once per frame
    void Update () {
		
	}
}
