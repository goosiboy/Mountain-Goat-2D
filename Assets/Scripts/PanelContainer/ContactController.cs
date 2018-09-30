using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactController : MonoBehaviour {

    private Vector2 initialMousePosition;
    private Vector2 mouseUpPosition;

    private float initialX;
    private float initialY;
    private float secondX;
    private float secondY;

    private bool isActive;
    private Event mouseEvent;
    private bool activateJump;
    public Movement movement;
    public float DEBUGFORCE = 200.0f;

    // Use this for initialization
    void Start () {
        this.initIsActive(false);
        this.initActivateJump(false);
	}
     
    void OnGUI()
    {
        this.mouseEvent = Event.current;

        switch (this.mouseEvent.type)
        {
            case EventType.MouseDown:
                this.mouseDownConfig();
                break;
            case EventType.MouseDrag:
                break;
            case EventType.MouseUp:
                this.mouseUpConfig();
                this.executeJump();
                break;
        }
    }

    public void mouseDownConfig() {
        this.setIsActive(true);
        this.setInitialMousePosition(Camera.main.ScreenToWorldPoint((Vector2)Input.mousePosition));

        this.initialX = this.getInitialMousePosition().x;
        this.initialY = this.getInitialMousePosition().y;
    }

    public void mouseUpConfig() {
        this.setIsActive(false);
        this.setMouseUpPosition(Camera.main.ScreenToWorldPoint((Vector2)Input.mousePosition));

        this.secondX = this.getMouseUpPosition().x;
        this.secondY = this.getMouseUpPosition().y;
    }

    public void executeJump() {
        movement.jumpController(
            this.initialX, 
            this.initialY, 
            this.secondX, 
            this.secondY);
    }

    public void setInitialMousePosition(Vector2 initialMousePosition) {
        this.initialMousePosition = initialMousePosition;
    }

    public Vector2 getInitialMousePosition() {
        return this.initialMousePosition;
    }

    public void initIsActive(bool val) {
        this.isActive = val;
    }

    public void setIsActive(bool isActive) {
        this.isActive = isActive;
    }

    public bool getIsActive() {
        return this.isActive;
    }

    public void initActivateJump(bool activateJump) {
        this.activateJump = activateJump;
    }

    public void setActivateJump(bool activateJump) {
        this.activateJump = activateJump;
    }

    public bool getActivateJump(bool activateJump)
    {
        return this.activateJump;
    }

    public void setMouseUpPosition(Vector2 mouseUpPosition) {
        this.mouseUpPosition = mouseUpPosition;
    }

    public Vector2 getMouseUpPosition() {
        return this.mouseUpPosition;
    }



}
