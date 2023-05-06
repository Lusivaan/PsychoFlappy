using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    [Header("Configura��es")]
    [SerializeField] [Tooltip("Tag")] public string _tag; 
    
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] audio = GameObject.FindGameObjectsWithTag(_tag);

        if (audio.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }


}
