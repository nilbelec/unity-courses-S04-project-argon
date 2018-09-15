using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    void Awake()
    {
        int musicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        if (musicPlayers > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
    }
}