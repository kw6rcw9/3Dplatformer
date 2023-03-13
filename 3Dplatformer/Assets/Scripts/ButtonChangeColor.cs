using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonChangeColor : MonoBehaviour
{
    [SerializeField] GameObject _button_1;
    [SerializeField] GameObject _button_2;
    private Renderer _newRenderer1;
    private Renderer _newRenderer2;
    private Color _color;
    [SerializeField] GameObject _path;


    // Start is called before the first frame update
    void Start()
    {
        _newRenderer1 = _button_1.gameObject.GetComponent<Renderer>();
        _newRenderer2 = _button_2.gameObject.GetComponent<Renderer>();
        _path.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        FadePath();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Button_1")
        {
            _color = new Color(1, 0, 0);
            _newRenderer1.material.color = _color;

        }
        if (other.tag == "Button_2")
        {
            _color = new Color(1, 0, 0);
            _newRenderer2.material.color = _color;
            

        }



    }

    private void FadePath()
    {
        if( _newRenderer1.material.color == _color && _newRenderer2.material.color == _color)
        {
            _path.gameObject.SetActive(true);
            
        }
    }
} 
