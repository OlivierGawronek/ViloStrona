using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private static Player instance;
    private float speed = 3f;

    public bool canMove = true;
    [SerializeField]
    private Animator animator;

    private Vector2 move;

    [SerializeField]
    private GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            cam = GameObject.Find("MainCamera");
            Destroy(gameObject);
        }


    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        cam = GameObject.Find("MainCamera");
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        if (canMove)
        {
            if (x < 0) transform.localScale = new Vector2(-1.2f, 1.2f);
            if (x > 0) transform.localScale = new Vector2(1.2f, 1.2f);

            if (x != 0 || y != 0) animator.SetFloat("Speed", 4);
            else animator.SetFloat("Speed", 0);

            move = new Vector2(x, y).normalized;

            transform.Translate(move * speed * Time.fixedDeltaTime);

            if (cam != null)
            {
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
        else
        {
            x = 0;
            y = 0;
        }

        if (x != 0 || y != 0) animator.SetFloat("Speed", 4);
        else animator.SetFloat("Speed", 0);
    }

    
}
