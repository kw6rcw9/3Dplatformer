using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

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

        //Invoke("JumpPortal", 0.5f);
        JumpPortal();


    }
    void JumpPortal()
    {
        _rigidbody.AddForce(Vector3.up * _power, ForceMode.Impulse);
    }
    void NextLevel()
    {
        SceneManager.LoadScene("Second_level");
    }
    private void OnCollisionExit(Collision collision)
    {

        Invoke("NextLevel", 2);
    }
}
