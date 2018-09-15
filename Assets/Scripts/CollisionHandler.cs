using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    [Tooltip("In s")] [SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab in Player")] [SerializeField] GameObject deathFX;

    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }

    void StartDeathSequence()
    {
        print("Player is dying");
        SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);
    }

    void ReloadScene() // string referenced
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
