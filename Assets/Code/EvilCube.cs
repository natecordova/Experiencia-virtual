﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log($"Collision with: {collision.collider.gameObject.tag}");
        var otherObject = collision.collider.gameObject;
<<<<<<< HEAD
<<<<<<< HEAD
        if (otherObject.tag == "Player")
=======
        if (otherObject.tag == "evil")
>>>>>>> Initial commit
=======
        if (otherObject.tag == "evil")
>>>>>>> Initial commit
        {
            GameObject.Destroy(otherObject);
        }
    }
}
