using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Pipe : MonoBehaviour
{

    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            Score.Instanse.SetScore(1);
        }
    }
}
