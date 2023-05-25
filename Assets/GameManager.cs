using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    [Header("ゲーム起動判定")]
    bool _isGame = true;
    [SerializeField]
    [Header("タワーHP")]
    public float _towerhp = 5f;
    [SerializeField]
    [Header("経過時間")]
    public float _count;
    public float _time;
    [SerializeField]
    [Header("プレイ時間の初期値")]
    public float _GameOverTime = 60f;
    [Header("クリア、ゲームオーバー画像")]
    [SerializeField] GameObject _gameover;
    [Header("スコア")]
    [SerializeField]
    public static int _totalScore = 0;
    [SerializeField]Text _timetext;
    [SerializeField] Text _scoreText;
    [SerializeField] Text _towerHpText;
    [SerializeField] scene scene;
    PlayerController _playercontroller;
    [Header("プレイヤーprehub")]
    [SerializeField] GameObject _player;
    void Start()
    {
        _totalScore = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (_isGame == true)
        {
            Time();
            _scoreText.text = $"{_totalScore.ToString("0000")}";
            _towerHpText.text = $"{_towerhp.ToString("0")}";
        }
        if (_towerhp <= 0)//敗北
        {
            _isGame = false;
            scene.LoadScenes();
        }
        void Time()
        {
            _time += UnityEngine.Time.deltaTime;
            _count = _GameOverTime - _time;
            _timetext.text = $"{_count.ToString("F0")}";
        }
    }
    public void Score(int _score)
    {
        _totalScore += _score;
    }
}