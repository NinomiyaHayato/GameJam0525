using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoroller : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _moveSpeed;
    [SerializeField] public float _moveSpeed2;
    [SerializeField] int _hp;
    [SerializeField] Vector3 _position;
    [SerializeField] Vector3 _TargetPosition;
    [SerializeField] float _rotedSpeed;
    float _distance;
    [SerializeField] float _stopDistance;
    GameManager _gam;
    // Start is called before the first frame update
    void Start()
    {
        _moveSpeed2 = Resources.Load<EnemyData>("EnemyData").Speed;
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }
    public void Damage(int damage)
    {
        _hp -= damage;
        if(_hp <= 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().Score(100);
            Destroy(this.gameObject);
        }
    }
    public void EnemyMove()
    {
        _position = this.transform.position;
        _TargetPosition = GameObject.Find("Target").transform.position;
        _distance = Vector3.Distance(_position, _TargetPosition);
        if (_distance >= _stopDistance)
        {
            Vector3 dir = (_TargetPosition - this.transform.position).normalized * _moveSpeed;
            _rb.velocity = dir * _moveSpeed2;
            if(_TargetPosition.x > this.transform.position.x)
            {
                transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
            }
            else
            {
                transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>()._towerhp--;
            Destroy(this.gameObject,0.1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Damage(1);
        }
    }
}
