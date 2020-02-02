using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trollManager : MonoBehaviour
{
    public GameObject prefab;
    private void OnMouseDown()
    {
        Instantiate(prefab, new Vector3(1.58f, -4.87f, -0.01f), Quaternion.identity);
    }
}
