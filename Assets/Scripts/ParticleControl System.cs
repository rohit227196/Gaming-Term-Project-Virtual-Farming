using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControlSystem : MonoBehaviour
{

    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private GameObject buttonHandler;

    void Awake()
    {
        _particleSystem.enableEmission = false;
    }


    void Update()
    {
        if(GameFlow.done)
        {
            buttonHandler.GetComponent<GameFlow>().enabled = false;
            GameFlow.done = false;
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            _particleSystem.enableEmission = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _particleSystem.enableEmission = false;
        }
    }
}
