using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAnimation : MonoBehaviour
{
    private bool clear = true;
    public float speed;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "portal")
        {
            anim.Play("enemyAttack");
            clear = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (clear)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
    }
}
