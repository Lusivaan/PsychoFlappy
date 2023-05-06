using UnityEngine;

public class SpawnPipes : MonoBehaviour
{

    [Header("Configurações do Spawn")]
    [SerializeField] [Tooltip("Objeto que será spawnado")] private GameObject _pipe;
    [SerializeField] [Tooltip("Altura do objeto spawnado")] [Range(0, 10)] private float _height;
    [SerializeField] [Tooltip("Tempo entre spawns")] [Range(0, 10)] private float _maxTime;

    private float _timer = 0;
    public float _speedPipe = 0;

    private void Start()
    {
        Spawner();
    }


    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if(_timer > _maxTime)
        {
            Spawner();
            _speedPipe += 0.01f;
            _maxTime -= 0.005f;
        } 
    }

    private void Spawner()
    {
        GameObject newPipe = Instantiate(_pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-_height, _height), 0);
        Destroy(newPipe, 20f);
        _timer = 0;
    }
}
