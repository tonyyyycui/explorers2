using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;
    public float distanceToTheRight;
    public float movementSpeeds;
    // Use this for initialization
    void Start()
    {

        min = transform.position.x;
        max = transform.position.x + distanceToTheRight;

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(movementSpeeds* Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);

    }
}
