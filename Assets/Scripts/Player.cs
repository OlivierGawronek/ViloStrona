using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float speed = 4f;
    public bool canMove = true;
    private Vector2 move;

    [SerializeField]
    private Transform cam;

    // Start is called before the first frame update
    void Start()
    {

        float playerX = gameObject.transform.position.x;
        float playerY = gameObject.transform.position.y;

        playerX = PlayerPrefs.GetFloat("px");
        playerY = PlayerPrefs.GetFloat("py");
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {

        if (canMove)
        {

            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            if (x < 0) transform.localScale = new Vector2(-1.2f, 1.2f);
            if (x > 0) transform.localScale = new Vector2(1.2f, 1.2f);

            move = new Vector2(x, y).normalized;


            //bieg i ruch

            //if (Input.GetKey(key: KeyCode.LeftShift))
            //{
            //    transform.Translate(move * speed * Time.fixedDeltaTime * 1.5f);
            //}
            //else
            //{
            transform.Translate(move * speed * Time.fixedDeltaTime);
            //}



            if (transform.position.x < -1)
            {
                cam.transform.position = (new Vector3(-1, transform.position.y, -10));
            }
            else if (transform.position.x > 1)
            {
                cam.transform.position = (new Vector3(1, transform.position.y, -10));
            }
            else if (transform.position.x < 1 && transform.position.x > -1)
            {
                cam.transform.position = (new Vector3(transform.position.x, transform.position.y, -10));
            }

        }
    }

    void PositionSave()
    {
        PlayerPrefs.SetFloat("px", gameObject.transform.position.x);
        PlayerPrefs.SetFloat("py", gameObject.transform.position.y);
        PlayerPrefs.Save();
    }
}
