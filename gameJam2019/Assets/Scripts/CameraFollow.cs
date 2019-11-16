using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player").GetComponent<Transform>();
        distance = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position - distance;
    }
}
