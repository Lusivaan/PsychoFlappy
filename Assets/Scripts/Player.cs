using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Configuracoes do player")]
    [SerializeField] [Tooltip("Força do pulo")] [Range(0, 10)] private float _speed;


    [Header("Componentes")]
    [SerializeField] [Tooltip("Rigidbody2D do player")] private Rigidbody2D _rb2D;
    [SerializeField] [Tooltip("GameOver Canvas")] private GameObject _gameOver;
    [SerializeField] [Tooltip("ButtonStart Canvas")] private GameObject _buttonStart;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }

    }


    /// Pulo do player, adiciona velocidade a cada input.
    private void Jump()
    {
        _rb2D.velocity = Vector2.up * _speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _gameOver.SetActive(true);
        _buttonStart.SetActive(true);
        Time.timeScale = 0;

    }
}
