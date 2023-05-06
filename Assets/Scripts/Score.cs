using UnityEngine; 

public class Score : MonoBehaviour
{
    [SerializeField] [Tooltip("Controller")] Manager _controller;

    private void Start()
    {
        _controller = FindObjectOfType<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _controller._score++;
        _controller._scoreText.text = _controller._score.ToString();
    }
}
