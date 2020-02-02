using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spearmanManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(1.59f, -4.91f, -0.01f), Quaternion.identity);
    }
}
