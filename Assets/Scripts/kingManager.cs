using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kingManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(1.51f, -4.15f, -0.01f), Quaternion.identity);
    }
}
