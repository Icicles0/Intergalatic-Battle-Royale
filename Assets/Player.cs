using UnityEngine;

public class Player : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        rb.AddForce(_horizontal , 0, _vertical);
    }
}
