using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float DestroyTimer = 0.5f;
    public float speed = 1;
    public float damage;
    void Awake() {
        Destroy(gameObject, DestroyTimer);
    }
    void Update()
    {
        transform.Translate(transform.up * Time.deltaTime * speed, Space.World);
    }
    
}
