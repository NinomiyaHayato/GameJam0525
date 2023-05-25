using UnityEngine;

/// <summary>
/// ��莞�Ԃ����Ɏw�肵���v���n�u���� GameObject �𐶐�����R���|�[�l���g
/// </summary>
public class Generator : MonoBehaviour
{
    /// <summary>��莞�Ԃ����ɐ������� GameObject �̌��ƂȂ�v���n�u</summary>
    [SerializeField] GameObject[] Items;
    //�����ꏊ
    [SerializeField] Transform[] Positions;
    /// <summary>��������Ԋu�i�b�j</summary>
    [SerializeField] float _m_interval;
    /// <summary>�^�C�}�[�v���p�ϐ�</summary>
    float _m_timer;


    void Update()
    {
        // Time.deltaTime �́u�O�t���[������̌o�ߎ��ԁv���擾����
        // �����ώZ���āu�o�ߎ��ԁv�����߂�̂� Unity �ł̓T�^�I�ȃv���O���~���O�̃p�^�[���ł���
        _m_timer += Time.deltaTime;

        // �u�o�ߎ��ԁv���u��������Ԋu�v�𒴂�����
        if (_m_timer > _m_interval)
        {
            int item = Random.Range(0,Items.Length);
            int transform = Random.Range(0, Positions.Length);

            Instantiate(Items[item], Positions[transform]);

            _m_timer = 0;
        }
    }
}
