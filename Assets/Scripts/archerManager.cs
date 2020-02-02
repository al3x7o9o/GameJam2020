using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archerManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(1.44f, -5f, -0.01f), Quaternion.identity);
    }
}
