using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        Invoke("LoadFirstLevel", 2f);
	}

    void LoadFirstLevel(){
        SceneManager.LoadScene(1);
    }
}
