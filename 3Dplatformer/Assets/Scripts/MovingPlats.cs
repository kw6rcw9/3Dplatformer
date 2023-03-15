using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlats : MonoBehaviour
{
    [SerializeField] Transform[] _points;
    [SerializeField] float _speed = 1f;
   

    void Start()
    {
        transform.position = _points[0].position;

    }


    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, _points[1].position, _speed * Time.deltaTime);
        Invoke("Move1", 2);
        Invoke("Move2", 2);

    }

    void Move1()
    {
        transform.position = Vector3.MoveTowards(transform.position, _points[1].position, _speed * Time.deltaTime);

    }
    void Move2()
    {
        transform.position = Vector3.MoveTowards(transform.position, _points[0].position, _speed * Time.deltaTime);

    }


}
    
