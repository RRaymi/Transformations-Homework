using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 currentScale = transform.localScale;
        transform.localScale = new Vector3(currentScale.x + _speed, currentScale.y + _speed, currentScale.z + _speed);
    }
}
