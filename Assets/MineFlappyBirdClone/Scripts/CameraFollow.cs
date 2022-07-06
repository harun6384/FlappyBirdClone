using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject character;
    public float distance;



    private void Start()
    {

    }

    private void LateUpdate()
    {
        Vector3 characterPosition = new Vector3(character.transform.position.x, 5f, character.transform.position.z - distance);
        this.transform.position = characterPosition;
    }
}
