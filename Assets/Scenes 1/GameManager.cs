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
    public float _time;
    [SerializeField]
    [Header("スコア")]
    public static int _totalScore = 0;
    [SerializeField]Text _timetext;
    [SerializeField] Text _scoreText;
    [SerializeField] Text _towerHpText;
    scene scene;
    [SerializeField] string _sceneName;
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
            _scoreText.text = $"Score:{_totalScore.ToString("0000")}";
            _towerHpText.text = $"Hp:{_towerhp.ToString("0")}";
        }
        if (_towerhp <= 0)//敗北
        {
            _isGame = false;
            SceneManager.LoadScene(_sceneName);
        }
        void Time()
        {
            _time += UnityEngine.Time.deltaTime;
            _timetext.text = $"Time:{_time.ToString("F0")}";
        }
    }
    public void Score(int _score)
    {
        _totalScore += _score;
    }
}