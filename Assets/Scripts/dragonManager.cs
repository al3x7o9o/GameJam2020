using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(1.25f, -2.5f, -0.01f), Quaternion.identity);
    }
}
