using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMove : MonoBehaviour
{
    [SerializeField] public GameObject bonus;
    [SerializeField] public float speed;

    void FixedUpdate()
    {      
        bonus.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
