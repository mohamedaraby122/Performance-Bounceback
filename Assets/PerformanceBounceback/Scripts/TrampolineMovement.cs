using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineMovement : MonoBehaviour {

    public Vector3 direction = new Vector3(1,0,0);
    public float _MoveSpeed = 3.5f;
    public float _MoveTime = 3f;
    private float _Time;
    private Rigidbody _Rg;

    void Start() {
        _Rg = GetComponent<Rigidbody>();
    }
    void Update () {
        _Time += Time.deltaTime;
        if(_Time > _MoveTime)
        {
            _Time = 0;
            direction = direction * -1;
        }		
	}
    void FixedUpdate() {
        _Rg.MovePosition(transform.position += direction * Time.deltaTime * _MoveSpeed);
    }
}
