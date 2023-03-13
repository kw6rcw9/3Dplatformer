using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button : MonoBehaviour
{
    [SerializeField] GameObject _button_1;
    [SerializeField] GameObject _button_2;
    private Renderer _newRenderer;
    private Color _color;


    // Start is called before the first frame update
    void Start()
    {
        _newRenderer = _button_1.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Button_1")
        {
            _color = new Color(1, 0, 0);
            _newRenderer.material.color = _color;

        }
        
    }
} 
