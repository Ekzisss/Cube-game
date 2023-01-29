using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerLvl1 : MonoBehaviour
{
    public float _speed = 5;
    private Rigidbody _rb;

    private float x = 0f;
    private float z = 0f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(x * _speed, _rb.velocity.y, z * _speed);

        _rb.velocity = move;
        //transform.Translate(move * Time.deltaTime, Space.World);
    }
}
