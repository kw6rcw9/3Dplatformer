using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBalls : MonoBehaviour
{
    [SerializeField] GameObject _greenball;
    [SerializeField] GameObject _yellowball;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _greenwall;
    [SerializeField] GameObject _yellowwall;
    private Renderer _renderer;
    private Renderer _newrenderer;
    private Rigidbody _rigidbody;
    private Rigidbody _rigidbody2;
    private Color _color;
    void Start()
    {
        _greenball.SetActive(true);
        _yellowball.SetActive(true);
        _renderer = _player.GetComponent<Renderer>();
        _yellowwall.gameObject.GetComponent<BoxCollider>().isTrigger = false;
        _greenwall.gameObject.GetComponent<BoxCollider>().isTrigger = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GreenBall")
        {
            _newrenderer = other.GetComponent<Renderer>();
            _color = _newrenderer.material.color;
            _renderer.material.color = _color;
            _greenball.SetActive(false);
            _yellowball.SetActive(true);

            _greenwall.gameObject.GetComponent<BoxCollider>().isTrigger = true;
            _yellowwall.gameObject.GetComponent<BoxCollider>().isTrigger = false;




        }
        if(other.tag == "YellowBall")
        {
            _newrenderer = other.GetComponent<Renderer>();
            _color = _newrenderer.material.color;
            _renderer.material.color = _color;
            _yellowball.SetActive(false);
            _greenball.SetActive(true);

            _yellowwall.gameObject.GetComponent<BoxCollider>().isTrigger = true;
            _greenwall.gameObject.GetComponent<BoxCollider>().isTrigger = false;


        }
    }
}
