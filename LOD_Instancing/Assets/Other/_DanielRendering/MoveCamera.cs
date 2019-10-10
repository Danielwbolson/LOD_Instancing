using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    Vector2 prevMousePos;
    Vector2 currMousePos;
    bool mouseDown = false;
    int speed;

    Camera cam;
    Transform camTransform;

    // Update is called once per frame
    void FixedUpdate() {
        if (cam == null) {
            cam = Camera.main;
            camTransform = Camera.main.transform;
        }

        float lrAxisValue = Input.GetAxis("Horizontal");
        float udAxisValue = Input.GetAxis("Vertical");

        currMousePos = Input.mousePosition;

        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = 3;
        } else {
            speed = 1;
        }

        if (Input.GetMouseButton(1)) {
            if (!mouseDown) {
                mouseDown = true;
                prevMousePos = currMousePos;
            }
            Vector3 diff = currMousePos - prevMousePos;

            if (diff.x > 0) diff.x = 2f;
            else if (diff.x < 0) diff.x = -2f;

            if (diff.y > 0) diff.y = 2f;
            else if (diff.y < 0) diff.y = -2f;

            camTransform.Rotate(camTransform.right, -diff.y * speed, Space.World);
            camTransform.Rotate(Vector3.up, diff.x * speed, Space.World);

            prevMousePos = currMousePos;
        } else {
            if (mouseDown) {
                mouseDown = false;
            }
        }
        camTransform.Translate(camTransform.forward * udAxisValue * speed, Space.World);
        camTransform.Translate(camTransform.right * lrAxisValue * speed, Space.World);
    }
}
