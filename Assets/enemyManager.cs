using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Quaternion tmp = new Quaternion(0, 180, 0, 0);
        Instantiate(prefab, new Vector3(60f, -5f, -0.01f), tmp);
    }
}
