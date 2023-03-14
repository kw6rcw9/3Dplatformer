using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PortalToSecondLevel : MonoBehaviour
{
    Rigidbody _rigidbody;
    [SerializeField] GameObject _player;
    [SerializeField] float _power;
    // Update is called once per frame
    private void Start()
    {
        _rigidbody = _player.GetComponent<Rigidbody>();
        
    }
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        Thread.Sleep(100);
        _rigidbody.AddForce(Vector3.up * _power, ForceMode.Impulse );
    }
}
