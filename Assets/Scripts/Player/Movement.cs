using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float force;
    private bool isJumping = false;
    private Rigidbody2D _rigidBody2D;

    private float initialX;
    private float initialY;
    private float secondX;
    private float secondY;

    private void Awake() {
        _rigidBody2D = gameObject.AddComponent<Rigidbody2D>();
    }

    public void doJump(
            float _force, 
            float iX, 
            float iY, 
            float sX, 
            float sY)
    {
        this.initialX = iX;
        this.initialY = iY;
        this.secondX = sX;
        this.secondY = sY;

        if (!this.getIsJumping()) {

            this.handleDirection();
            this.setForce(_force);

            this.setIsJumping(true);
            _rigidBody2D.AddForce(Vector2.up * this.getForce());
            this.resetForce();

            Debug.Log("Player is jumping");

        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "cloud")
        {
            this.setIsJumping(false);
            Debug.Log("Player has landed");
        }
    }

    private void handleDirection()
    {

    }

    public void setIsJumping(bool isJumping) {
        this.isJumping = isJumping;
    }

    public void resetForce() {
        this.force = 0;
    }

    public bool getIsJumping() {
        return this.isJumping;
    }

    public void setForce(float _force) {
        this.force = _force;
    }

    public float getForce() {
        return this.force;
    }


}
