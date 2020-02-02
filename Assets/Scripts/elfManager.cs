using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elfManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(1.48f, -5.08f, -0.01f), Quaternion.identity);
    }
}
