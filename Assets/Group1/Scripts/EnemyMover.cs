using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private int _radius = 4;
    private Vector3 _target;

    private void Update()
    {
        DefineTarget();
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
    }

    private void DefineTarget()
    {
        if (transform.position == _target)
        {
            _target = Random.insideUnitCircle * _radius;
        }
    }
}