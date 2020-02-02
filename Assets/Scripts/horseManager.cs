using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(3.6f, -3.98f, -0.01f), Quaternion.identity);
    }
}
