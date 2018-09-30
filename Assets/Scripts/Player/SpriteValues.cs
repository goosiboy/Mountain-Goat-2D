using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteValues : MonoBehaviour {

    private float sizeX;
    private float sizeY;
    private float centerX;
    private float centerY;
    private BoxCollider2D boxCollider;

    void Awake()
    {
        initPlayer();
    }

    private void initPlayer()
    {
        setCenterPoint();
    }

    private void setCenterPoint()
    {
        boxCollider = gameObject.GetComponent(typeof(BoxCollider2D)) as BoxCollider2D;
        sizeX = boxCollider.size.x;
        sizeY = boxCollider.size.y;

        centerX = sizeX / 2;
        centerY = sizeY / 2;

    }

    // Use this for initialization
    void Start () {



	}
	
	// Update is called once per frame
	void Update () {

    }



}
