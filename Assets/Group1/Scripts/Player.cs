using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;

    void Update()
    {
        var direction = GetInputDirection();
        Move(direction);
    }

    private Vector3 GetInputDirection()
    {
        var inputDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        return inputDirection;
    }

    private void Move(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    public void ApplySpeedBoost(float multiplier, float durationTime)
    {
        _speed *= multiplier;
       StartCoroutine(ExpirationBonus(multiplier, durationTime));
    }

    public IEnumerator ExpirationBonus(float multiplier, float durationTime)
    {
        while (durationTime > 0 )
        {
            durationTime -= Time.deltaTime;
            yield return null;
        }

        _speed /= multiplier;
    }
}
