using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] float _speed = 1.0f;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += _speed * Time.deltaTime;
        transform.position = pos;
    }
}
