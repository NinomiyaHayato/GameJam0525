using UnityEngine;

/// <summary>
/// Enemyの移動速度を変更するクラス
/// アイテムにアタッチして使用する
/// </summary>
public class ESpeedDownItem : MonoBehaviour
{
    [Header("Enemyの移動速度の変更値")]
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
        // 接触したゲームオブジェクトのタグが”Enemy”か確認する
        if (col.gameObject.tag == "Enemy")
        {
            _Espeed = GameObject.Find("Enemy").GetComponent<EnemyContoroller>()._moveSpeed2;
            _Espeed -= _downspeed;
        }
    }
}