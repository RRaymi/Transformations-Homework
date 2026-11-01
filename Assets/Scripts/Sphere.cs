using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Time.deltaTime, 0f, 0f);
    }
}
