using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExMover : MonoBehaviour
{
    public float speed = 2.0f;
    public Vector3 target = new Vector3(-4.0f, 3.0f, -4.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
}
