using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBallController : MonoBehaviour
{
    public float speed = 2.0f;
    public Vector3 RightBallPos = new Vector3(-1.2f, 5.0f, 6.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var step = Time.deltaTime * speed;
        transform.position = Vector3.MoveTowards( transform.position , RightBallPos, step );
    }
}
