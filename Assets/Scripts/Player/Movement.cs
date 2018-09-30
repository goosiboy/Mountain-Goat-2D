using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float force = 200.0f;
    private bool isJumping = false;
    private Rigidbody2D _rigidBody2D;

    private float unFormattedX;
    private float unFormattedY;
    private float formattedX;
    private float formattedY;

    private void Awake() {
        _rigidBody2D = gameObject.AddComponent<Rigidbody2D>();
    }

    public void jumpController(
            float iX, 
            float iY, 
            float sX, 
            float sY)
    {
        if (!this.getIsJumping()) {
            this.executeJump(this.handleForce(this.handleDirection(iX, iY, sX, sY)));
        }
    }

    private float handleDirection(float iX, float iY, float sX, float sY) { 
        if (iY >= sY) {
            double dist = System.Math.Sqrt(System.Math.Pow(iX - sX, 2) + System.Math.Pow(iY - sY, 2));
            Debug.Log("distance: " + (float) dist);
            return (float) dist;
        } else {
            Debug.Log("Alaspäin ei voi hypätä");
            return 0.0f;
        }
    }

    private float handleForce(float dist) {

        if (dist > 0.0) {
            return (this.force * dist);
        } else {
            return 0.0f;
        }
    }

    private void executeJump(float _force) {
        this.setIsJumping(true);
        _rigidBody2D.AddForce(Vector2.up * _force);

        Debug.Log("Player is jumping");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cloud")
        {
            this.setIsJumping(false);
            Debug.Log("Player has landed");
        }
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
