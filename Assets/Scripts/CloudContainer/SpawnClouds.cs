using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour {

    private GameObject cloud;
    private GameObject cloudInstance;
    public List<GameObject> cloudArray = new List<GameObject>();

    private SpriteRenderer spriteR;
    private Sprite sprite;

    private void Awake()
    {

        /*
        cloud = new GameObject();
        sprite = Resources.Load<Sprite>("cloud");

        for (int i = 0; i < amountOfClouds; i++)
        {
            cloudInstance = Instantiate(cloud) as GameObject;
            cloudInstance.name = "Cloud" + i;
            cloudInstance.AddComponent<SpriteRenderer>();

            spriteR = cloudInstance.GetComponent<SpriteRenderer>();
            spriteR.sprite = sprite;

            cloudArray.Add(cloudInstance);
            print("cloudArray"+1+": " + cloudArray[i].name);
        }
        */



    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
