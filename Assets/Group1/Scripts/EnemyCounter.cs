using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField] private SpeedBonus _speedBonus;
    
    public List<Enemy> Enemies { get; private set; }

    public event UnityAction AllEnemiesDied;

    private void OnEnable()
    {
        Enemies = new List<Enemy>(GetComponentsInChildren<Enemy>());

        foreach (var enemy in Enemies)
        {
            enemy.Died += OnEnemyDied;
        }
    }

    private void OnDisable()
    {
        foreach (var enemy in Enemies)
        {
            enemy.Died -= OnEnemyDied;
        }
    }

    private void OnEnemyDied(Enemy enemy)
    {
        if (enemy.IsSpeedBooster)
        {
            _speedBonus.ApplyBonus();
        }

        enemy.Died -= OnEnemyDied;
        Enemies.Remove(enemy);

        if (Enemies.Count == 0)
        {
            AllEnemiesDied?.Invoke();
        }

        
    }
}
