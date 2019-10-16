using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public bool hit;
    public GameObject dialog;
    // Start is called before the first frame update
    void Start()
    {
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed * -1.0f ;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * -1.0f;
        }

        if ( hit)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                dialog.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "Trigger")
        {
            hit = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trigger")
        {
            hit = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trigger")
        {
            hit = false;
        }
    }
}
