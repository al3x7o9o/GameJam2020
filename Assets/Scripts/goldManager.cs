using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class goldManager : MonoBehaviour
{
    TextMesh text;
    void Start()
    {
        text = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = global.gold.ToString();
    }
}
