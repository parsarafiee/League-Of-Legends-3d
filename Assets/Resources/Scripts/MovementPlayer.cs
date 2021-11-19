using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    Vector3 newPostion;
    public float speed;
    public float walkingRange;
    public float rotationSpeed =0.2f;

    public GameObject graphics;
    
    void Start()
    {
        newPostion = transform.position;
    }

    void Update()
    {

        if (Vector3.Distance(this.transform.position,newPostion) >walkingRange )
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, newPostion, speed * Time.deltaTime);
            Quaternion transRot = Quaternion.LookRotation(newPostion - transform.position, Vector3.up);
            graphics.transform.rotation = Quaternion.Slerp(transRot, graphics.transform.rotation, rotationSpeed);
        }
        
    }
    public void ReciveNewPositon(Vector3 newPos)
    {
        newPostion = newPos;
    }
}
