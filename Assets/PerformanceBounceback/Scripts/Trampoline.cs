using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

     ParticleSystem _Effect;

    void Start() {
        _Effect = GetComponentInChildren<ParticleSystem>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            //Score Point
            GameManager.score++;
            //Particle effect
            _Effect.Play();
        }
    }
}
