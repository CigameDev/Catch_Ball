using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed =10;
    float xDirection;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");//3d thuong dung GetAxis
        float moveStep = moveSpeed *xDirection *Time.deltaTime;
        if ((this.transform.position.x <= -6.85f && xDirection == -1) || (this.transform.position.x >= 6.85 && xDirection == 1))
            return;
        this.transform.position += new Vector3(moveStep, 0, 0);
    }
}
