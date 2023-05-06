using UnityEngine;
using TMPro;

public class Record : MonoBehaviour
{

    [Header("Valores do record")]
    [SerializeField] [Tooltip("Pontuação Atual")] public int _scoreAtual;
    [SerializeField] [Tooltip("Record")] public int _record;
    [SerializeField] [Tooltip("GameManager")] Manager _manager;
    [SerializeField] [Tooltip("Texto")] public TextMeshProUGUI _recordText;

    // Start is called before the first frame update
    void Start()
    {
        _manager = FindObjectOfType<Manager>();

        _scoreAtual = 0;
        _record = 0;

        if(PlayerPrefs.HasKey("FlappyScene" + "score"))
        {
            _record = PlayerPrefs.GetInt("FlappyScene" + "score");        

        }
    }

    // Update is called once per frame
    void Update()
    {
        _scoreAtual = _manager._score;
        CheckScore();
        UpdateScore();
    }

    void CheckScore()
    {
        if (_scoreAtual > _record)
        {
            _record = _scoreAtual;
            PlayerPrefs.SetInt("FlappyScene" + "score", _record);
        }
    }

    void UpdateScore()
    {
        _recordText.text = _record.ToString();
    }
}
