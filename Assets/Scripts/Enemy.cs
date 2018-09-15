using UnityEngine;

public class Enemy : MonoBehaviour {

    void Start()
    {
        AddNonTriggerBoxCollider();
    }

    void AddNonTriggerBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
