using UnityEngine;

/// <summary>
/// Enemy�̈ړ����x��ύX����N���X
/// �A�C�e���ɃA�^�b�`���Ďg�p����
/// </summary>
public class ESpeedDownItem : MonoBehaviour
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

    private void OnTriggerEnter2D(Collider2D col)
    {
        // �ڐG�����Q�[���I�u�W�F�N�g�̃^�O���hEnemy�h���m�F����
        if (col.gameObject.tag == "Enemy")
        {
            _Espeed = GameObject.Find("Enemy").GetComponent<EnemyContoroller>()._moveSpeed2;
            _Espeed -= _downspeed;
        }
    }
}