using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 currentScale = transform.localScale;
        transform.localScale = new Vector3(currentScale.x + Time.deltaTime * _speed, currentScale.y + Time.deltaTime * _speed, currentScale.z + Time.deltaTime * _speed);
    }
}
