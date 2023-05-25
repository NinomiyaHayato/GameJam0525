using UnityEngine;

/// <summary>
/// Enemy�̈ړ����x��ύX����N���X
/// �A�C�e���ɃA�^�b�`���Ďg�p����
/// </summary>
public class ESpeedDown : MonoBehaviour
{
    [Header("Enemy�̈ړ����x�̕ύX�l")]
    [SerializeField] float _downspeed;
    [SerializeField] float _destroytime;
    public float _Espeed;
    public float _time;

    void Update()
    {
        _time += Time.deltaTime;
        if (_time >= _destroytime)
        {
            _time = 0;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Resources.Load<EnemyData>("EnemyData").Speed -= 1;
        }
        Destroy(gameObject);
    }
}