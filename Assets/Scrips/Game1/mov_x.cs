using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_x : MonoBehaviour
{
    Rigidbody2D rb;
    public float Velocidad;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * Velocidad, 0);
    }
}
