using UnityEngine;

public class Pipes : MonoBehaviour
{
    [Header("Configurações do Pipes")]
    [SerializeField] [Tooltip("Velocidade dos Pipes")] [Range(0, 10)] private float _speed;
    [SerializeField] [Tooltip("Controller")] SpawnPipes _spawn;

    private void Start()
    {
        _spawn = FindObjectOfType<SpawnPipes>();

        _speed = _spawn._speedPipe + _speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
