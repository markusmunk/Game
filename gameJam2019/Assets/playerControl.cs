using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float defaultSpeed = 3;
    public float speed = 3;
    public float jumpForce = 5;
    public Vector3 gravity = new Vector3(0, -20, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // once every 0.2 seconds 
    private void FixedUpdate()
    {

        rb.AddForce(gravity);

        if (Input.GetKey(KeyCode.A))
        {
            // player should strafe left
            Vector3 strafeLeft = Camera.main.transform.right;
            strafeLeft.y = 0.0F;
            rb.AddForce(strafeLeft * speed * -1);
          
        }
        if (Input.GetKey(KeyCode.D))
        {
            // player should strafe right
            Vector3 strafeRight = Camera.main.transform.right;
            strafeRight.y = 0.0F;
            rb.AddForce(strafeRight * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            // player should go forward
            Vector3 forward = Camera.main.transform.forward;
            forward.y = 0.0F;
            rb.AddForce(forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // player should go back
            Vector3 backwards = Camera.main.transform.forward;
            backwards.y = 0.0F;
            rb.AddForce(backwards * speed * - 1);
            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            gravity = gravity * -1;
            jumpForce = jumpForce * -1;
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
