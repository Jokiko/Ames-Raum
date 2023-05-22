using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform[] targets;
    public float speed = 3f;
    private int currentTargetIndex = 0;
    private bool isMoving = false;

    void Start()
    {
        GameObject target1 = GameObject.Find("Camera1"); 
        GameObject target2 = GameObject.Find("Camera2"); 
        GameObject target3 = GameObject.Find("Camera3");
        GameObject target4 = GameObject.Find("Camera4");  
        GameObject target5 = GameObject.Find("Camera5");  
        
        targets = new Transform[] { target1.transform, target2.transform, target3.transform, target4.transform, target5.transform };
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMoving = !isMoving;
        }

        //return to starting point
        if (!isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Camera0").transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, GameObject.Find("Camera0").transform.rotation, speed * Time.deltaTime);
        }

        //move towards current target position until camera arrives there, then choose next target
        if (isMoving)
        {
            Vector3 targetPosition = targets[currentTargetIndex].position;
            Quaternion targetRotation = targets[currentTargetIndex].rotation;

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) == 0f)
            {
                currentTargetIndex = (currentTargetIndex + 1) % targets.Length;
            }
        }
    }

}