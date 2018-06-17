using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("LoadFirstLevel", 10f);
	}

    void LoadFirstLevel(){
        SceneManager.LoadScene(1);
    }
}
