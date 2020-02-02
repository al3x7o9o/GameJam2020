using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wizzardManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(1.28f, -4.67f, -0.01f), Quaternion.identity);
    }
}
