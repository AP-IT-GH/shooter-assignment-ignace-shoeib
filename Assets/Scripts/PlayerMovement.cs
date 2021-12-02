using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerMovement : MonoBehaviour
{
    public float xSpeed = 10f;
    public float ySpeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = horizontal * Time.deltaTime * xSpeed;
        float xNewPos = xOffset + transform.localPosition.x;
        float vertical = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = vertical * Time.deltaTime * ySpeed;
        float yNewPos = yOffset + transform.localPosition.y;
        transform.localPosition = new Vector3(Mathf.Clamp(xNewPos,-20,20),Mathf.Clamp(yNewPos,-10,10), transform.localPosition.z);
    }
}
