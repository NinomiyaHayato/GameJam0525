using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    [Header("�Q�[���N������")]
    bool _isGame = true;
    [SerializeField]
    [Header("�^���[HP")]
    public float _towerhp = 5f;
    [SerializeField]
    [Header("�o�ߎ���")]
    public float _time;
    [SerializeField]
    [Header("�X�R�A")]
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
        if (_towerhp <= 0)//�s�k
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