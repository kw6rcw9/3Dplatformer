using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] float t = 0;
    [SerializeField] float Amp = 0.25f;
    [SerializeField] float Freq = 2;
    [SerializeField] float Offset = 0;
    [SerializeField] Vector3 StartPos;
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        t = t + Time.deltaTime;
        Offset = Amp * Mathf.Sin(t*Freq);

        transform.position = StartPos + new Vector3(0, 0, Offset);
        
    }
}
