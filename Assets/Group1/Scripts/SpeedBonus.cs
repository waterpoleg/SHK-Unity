using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _multiplier = 2f;
    [SerializeField] private float _durationTime = 2f;

    public void ApplyBonus()
    {
        _player.ApplySpeedBoost(_multiplier, _durationTime);
    }
}
