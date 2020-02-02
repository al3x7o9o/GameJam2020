using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knightManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(1.42f, -4.76f, -0.01f), Quaternion.identity);
    }
}
