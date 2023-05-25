using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recover : MonoBehaviour
{
    float _tower;
    //クールタイム
    [SerializeField] float _coolTime;
    float _timer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            _tower = GameObject.Find("GameManager").GetComponent<GameManager>()._towerhp;            if(_tower < 5)
            {
                _tower += 1;
            }
            Destroy(gameObject);
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
