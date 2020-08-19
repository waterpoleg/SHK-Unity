using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private EnemyCounter _counter;
    [SerializeField] private float _distance = 0.2f;

    void Update()
    {
        for (var i = 0; i < _counter.Enemies.Count; i++)
        {
            var distance = Vector3.Distance(_player.transform.position, _counter.Enemies[i].transform.position);
            if (distance < _distance)
            {
                _counter.Enemies[i].Die();
            }
        }
    }
}
