using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class EnterpriseMovement : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float mulVel;

    // Start is called before the first frame update
    void Start()
    {
        this.rbd = GetComponent<Rigidbody2D>();
        this.mulVel = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        this.rbd.velocity = new Vector2(x, y) * this.mulVel;
    }
}
