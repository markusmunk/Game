using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    int hidden;
    public float speed = 3;
    public float jumpForce = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // once every 0.2 seconds 
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // player should go left
            rb.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // player should go right
            rb.AddForce(Vector3.right * speed);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            // player should go up
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
