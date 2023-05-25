using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Recover : MonoBehaviour
{
    [SerializeField] GameObject _tower;
    //クールタイム
    [SerializeField] float _coolTime;
    float _timer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //_tower = GameObject.Find("tower").GetComponent<GameManager>();

            //HPを増やす処理
            //_tower.Hp = _tower.Hp + 3;

            //if(_tower.Hp > _tower.MaxHp)
            //{
            //    _tower.Hp = _tower.MaxHp
            //}
        }
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if( _timer > _coolTime )
        {
            Destroy(gameObject);
        }
    }
}
