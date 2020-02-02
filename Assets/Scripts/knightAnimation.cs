using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class knightAnimation : MonoBehaviour
{
    private bool clear = true;
    Animator anim;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Enemy")
        {
            anim.Play("silver_knight_attack");
            clear = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 60.1f)
        {
            if (global.progression < 100)
            {
                global.progression += 1;
            }
            if (global.progression >= 100)
            {
                global.progression = 100;
            }
            Destroy(gameObject);
        }
        if (clear)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}
