using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMechanics : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    private Rigidbody _rigidbody;
    [SerializeField] private float jumpForce;
    private Animator anim;

    public event System.Action OnPlayerDeath;
    public event System.Action OnPlayerScore;

    private void Start()
    {
        anim = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }

    private void Update()
    {
        transform.Translate(forwardSpeed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = _rigidbody.velocity * 0f;
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            anim.SetBool("Wingbeated", true);
        }
        else
        {
            anim.SetBool("Wingbeated", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Ground"))
        {
            if (OnPlayerDeath != null)
            {
                OnPlayerDeath();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            if (OnPlayerScore != null)
            {
                OnPlayerScore();
            }
        }
    }
}
