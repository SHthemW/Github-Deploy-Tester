using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class TransformCtrller : MonoBehaviour
{
    [SerializeField] 
    private Vector3 _moveSpeed;

    [SerializeField]
    private Vector3 _rotateSpeed;

    private void FixedUpdate()
    {
        transform.Translate(_moveSpeed);
        transform.Rotate(_rotateSpeed);
    }
}
