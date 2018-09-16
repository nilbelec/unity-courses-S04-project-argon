using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePoints = 10;
    [SerializeField] int lifePoints = 10;

    ScoreBoard scoreBoard;

    void Start()
    {
        AddNonTriggerBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void AddNonTriggerBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (lifePoints <= 0)
            DestroyEnemy();
    }

    private void ProcessHit()
    {
        scoreBoard.ScoreHit(scorePoints);
        lifePoints--;
    }

    private void DestroyEnemy()
    {
        Instantiate(deathFX, transform.position, Quaternion.identity, parent);
        Destroy(gameObject);
    }
}
