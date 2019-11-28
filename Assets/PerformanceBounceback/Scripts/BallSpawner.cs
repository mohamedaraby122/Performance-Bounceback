using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public static BallSpawner _CurrBall;

    public GameObject _PoolingBall;
    public int _AmountOfBalls = 20; 
    public List<GameObject> _PooledBalls = new List<GameObject>(); 
    public static int _NumOfBalls = 0;

    private float _CoolDown;
    private float _CollLength = 0.5f;

    void Awake()
    {
        _CurrBall = this; 
    }

    void Start()
    {
        for (int i = 0; i < _AmountOfBalls; i++)
        {
            GameObject obj = Instantiate(_PoolingBall);
            obj.SetActive(false);
            _PooledBalls.Add(obj);
        }
    }

    public GameObject GetPooledBall()
    {
        _NumOfBalls++;
        if (_NumOfBalls > (_AmountOfBalls - 1))
        {
            _NumOfBalls = 0;
        }
        return _PooledBalls[_NumOfBalls];
    }
   	
	void Update () {
        _CoolDown -= Time.deltaTime;
        if(_CoolDown <= 0)
        {
            _CoolDown = _CollLength;
            SpawnBall();
        }		
	}

    void SpawnBall()
    {
        GameObject selectedBall = BallSpawner._CurrBall.GetPooledBall();
        selectedBall.transform.position = transform.position;
        Rigidbody selectedRigidbody = selectedBall.GetComponent<Rigidbody>();
        selectedRigidbody.velocity = Vector3.zero;
        selectedRigidbody.angularVelocity = Vector3.zero;
        selectedBall.SetActive(true);
    }
}
