using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    [Header("Configurações do Game")]
    [SerializeField] [Tooltip("Valor da pontucao")] public int _score;
    [SerializeField] [Tooltip("Texto")] public TextMeshProUGUI _scoreText;

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Sair();
        }
            
    }

    public void Sair()
    {
        Application.Quit();
    }
}
