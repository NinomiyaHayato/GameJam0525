using UnityEngine;

/// <summary>
/// 一定時間おきに指定したプレハブから GameObject を生成するコンポーネント
/// </summary>
public class Generator : MonoBehaviour
{
    /// <summary>一定時間おきに生成する GameObject の元となるプレハブ</summary>
    [SerializeField] GameObject[] Items;
    //生成場所
    [SerializeField] Transform[] Positions;
    /// <summary>生成する間隔（秒）</summary>
    [SerializeField] float _m_interval;
    /// <summary>タイマー計測用変数</summary>
    float _m_timer;


    void Update()
    {
        // Time.deltaTime は「前フレームからの経過時間」を取得する
        // これを積算して「経過時間」を求めるのは Unity での典型的なプログラミングのパターンである
        _m_timer += Time.deltaTime;

        // 「経過時間」が「生成する間隔」を超えたら
        if (_m_timer > _m_interval)
        {
            int item = Random.Range(0,Items.Length);
            int transform = Random.Range(0, Positions.Length);

            Instantiate(Items[item], Positions[transform]);

            _m_timer = 0;
        }
    }
}
