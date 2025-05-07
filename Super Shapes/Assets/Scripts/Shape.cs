﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    //Rigidbody for the object
    [Header("Rigidbody Object")]
    public Rigidbody2D rb;
    //Shrinking Speed
    [Header("Default Shrinking Speed")]
    public float shrinkSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        //Rotation of the rigidbody
        //at a random range
        rb.rotation = Random.Range(0, 360);
        //local scale for the Hexagon
        //equals one for all axes (x,y,z) times ten
        //meaning - localScale = (1,1,1) * 10
        transform.localScale = Vector3.one * 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x < 0.05f)
        {
            Destroy(gameObject);
            Score.score++;

        }
    }
}
