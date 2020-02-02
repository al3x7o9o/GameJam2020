using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;
public class wizzardAnimation : MonoBehaviour
{

    Animator anim;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 60.1f)
        {
            if (global.progression < 100)
            {
                global.progression += 6;
            }
            if (global.progression >= 100)
            {
                global.progression = 100;
            }
            Destroy(gameObject);
        }
        transform.position += Vector3.right * Time.deltaTime * speed;
    }
}
