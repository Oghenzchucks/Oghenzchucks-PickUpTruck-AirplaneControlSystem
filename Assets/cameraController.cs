using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public GameObject propeller;
    public Transform endMarker;
    public Transform endMarker2;

    // Start is called before the first frame update
    void Start()
    {

    }

    void MoveCameraTo()
    {
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, endMarker.position, speed * Time.deltaTime);
    }

    void MoveCameraOut()
    {
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, endMarker2.position, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        // verticalZoom = Input.GetKeyDown(KeyCode.W);

        if(Input.GetKey(KeyCode.Q))
        {
            MoveCameraTo();
        }

        if(Input.GetKey(KeyCode.Z))
        {
            MoveCameraOut();
        }

        // gets the user's horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        // horizontalZoom = Input.GetKeyDown(KeyCode.S);

        // move the plane forward at a constant rate
        transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime * horizontalInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * verticalInput * rotationSpeed * Time.deltaTime);
    }
}
