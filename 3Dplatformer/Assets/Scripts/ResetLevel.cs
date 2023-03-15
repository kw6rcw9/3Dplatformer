using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    [SerializeField] GameObject _player;

    



    private void Start()
    {
        
    }
    private void Update()
    {
        Reset();
        
    }

    private void Reset()
    {
        if(_player.transform.position.y < transform.position.y)
        {
            SceneManager.LoadScene("Second_level");
            

        }
    }
}
