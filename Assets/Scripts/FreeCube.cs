using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCube : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _rotationInterval;

    private float _rotationMinAngle = 0f;
    private float _rotationMaxAngle = 360f;
    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _rotationInterval)
        {
            transform.Rotate(0f, Random.Range(_rotationMinAngle, _rotationMaxAngle), 0f);
            _timer = 0f;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        
        Vector3 currentScale = transform.localScale;
        transform.localScale = new Vector3(currentScale.x + _scaleSpeed, currentScale.y + _scaleSpeed, currentScale.z + _scaleSpeed);
    }
}
