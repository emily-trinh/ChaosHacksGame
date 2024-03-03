using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleBounce : MonoBehaviour
{
    
    public double top = 0;

    public double bottom = 0;

    public int direction = 1;


    private void Start()
    {
        // pointIndex = 0;
    }

    private void Update()
    {
        MoveToNextPoint();
    }

    void MoveToNextPoint()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + direction * Time.deltaTime, transform.position.z);
        if(transform.position.y > top){
            direction = -direction;
        }

        if(transform.position.y < bottom) 
        {
            direction = -direction;
        }
    }
}
