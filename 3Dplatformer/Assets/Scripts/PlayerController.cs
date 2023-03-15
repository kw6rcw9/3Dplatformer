using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpPower;
    [SerializeField] ForceMode _forceMode;
    private bool _onGround = false;

    [SerializeField] private Animator _animator;

    void Update()
    {
        //PlayJump();
        PlayerMove();
        AnimationJump();
    }
    private void OnCollisionStay(Collision collision)
    {
        _onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _onGround=false;
    }
    //private void PlayJump()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space) && _onGround == true)
    //    {
    //        _rigidbody.AddForce(Vector3.up * _jumpPower, _forceMode);

    //    }
    //}

    private void AnimationJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _onGround == true)
        {
            _animator.SetTrigger("Jump");

        }


    }

    private void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        _rigidbody.velocity = new Vector3(z * _speed, _rigidbody.velocity.y, x * -_speed);

    }

}
