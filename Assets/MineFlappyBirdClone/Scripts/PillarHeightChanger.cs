using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarHeightChanger : MonoBehaviour
{
    private void Awake()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-3f, 1f), transform.position.z);
    }
}
