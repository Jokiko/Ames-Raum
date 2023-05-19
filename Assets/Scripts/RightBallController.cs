using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBallController : MonoBehaviour
{

    public float speed = 2.0f;
    public Vector3 LeftBallPos = new Vector3(-6.5f, 4.0f, -8.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var step = Time.deltaTime * speed;
        transform.position = Vector3.MoveTowards(transform.position, LeftBallPos , step);
    }
}
