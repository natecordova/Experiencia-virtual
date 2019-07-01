using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Transform trans;
    public Rigidbody2D body;
    public Animator anim;


    public GUIText text;

    public float walkingSpeed;
    public float jumpSpeed;

    private void Awake()
    {
        trans = this.transform;
        body = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  //Salta
        { // y-axis movement
            body.velocity += jumpSpeed * Vector2.up;
        }

        { // x-axis movement
            var v = body.velocity;
            var speed = 0f;
            if (Input.GetKey(KeyCode.A))  //Izquierda
            {
                speed += -walkingSpeed;
            }
            if (Input.GetKey(KeyCode.D))    //Derecha
            {
                speed += walkingSpeed;
            }
            v.x = speed;
            body.velocity = v;
            { // Rotation around y-axis
                if (speed > 0.01)
                {
                    trans.rotation = Quaternion.Euler(0, 0, 0);
                    text.text = "Moving Right";
                }
                else if (speed < -0.01)
                {
                    trans.rotation = Quaternion.Euler(0, 180, 0);
                    text.text = "Moving Left";
                }
            }
            anim.SetFloat("Speed", Mathf.Abs(speed));
        }
    }

}
