using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyR : MonoBehaviour
{
    float _time;
    [SerializeField] float _cooltime;
    [SerializeField] GameObject _enemy;

    GameObject _tower;
    [SerializeField] Vector3 _target;
    [SerializeField] Vector3 _vec = Vector3.forward;
    [SerializeField] float _quo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _tower = GameObject.FindGameObjectWithTag("Target");
        EnemyRes();
        RotateA();
    }
    public void EnemyRes()
    {
        _time += Time.deltaTime;
        if(_time > _cooltime)
        {
            Instantiate(_enemy, this.transform.position, this.transform.rotation);
            _time = 0;
        }
    }
    public void RotateA()
    {
        _target = _tower.transform.position;
        transform.RotateAround(_target, _vec, _quo * Time.deltaTime);
    }
}
