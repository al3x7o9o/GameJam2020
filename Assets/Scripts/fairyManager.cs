using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fairyManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(1.44f, -3.3f, -0.01f), Quaternion.identity);
    }
}
