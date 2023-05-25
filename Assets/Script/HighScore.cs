using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField] Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = $"High Score:{GameManager._totalScore.ToString("00000")}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
