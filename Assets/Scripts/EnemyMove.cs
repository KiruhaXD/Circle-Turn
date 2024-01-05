using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] public GameObject enemy;
    [SerializeField] public float speed;

    void FixedUpdate()
    {
        enemy.transform.Translate(speed * Time.deltaTime, 0, 0);

    }
}
