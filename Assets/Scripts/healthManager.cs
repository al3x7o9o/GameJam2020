using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class healthManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Transform bar = transform.Find("Bar");
        float life = global.hp / 100;
        bar.localScale = new Vector3(life, 1f);
    }
}
