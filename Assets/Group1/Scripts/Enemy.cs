using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private bool _isSpeedBooster = false;
    public bool IsSpeedBooster => _isSpeedBooster;
    
    public event Action<Enemy> Died;

    public void Die()
    {
        Died?.Invoke(this);
        Destroy(gameObject);
    }
}
