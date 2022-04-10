using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float speed = 4f;

    Vector2 move;

    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        move = new Vector2(x, y);


        //bieg i ruch
        if (Input.GetKey(key: KeyCode.LeftShift))
        {
            transform.Translate(move * speed * Time.fixedDeltaTime * 1.5f);
        }
        else
        {
            transform.Translate(move * speed * Time.fixedDeltaTime);
        }

        cam.transform.position = (new Vector3(transform.position.x, transform.position.y, -10));
        
    }
}
