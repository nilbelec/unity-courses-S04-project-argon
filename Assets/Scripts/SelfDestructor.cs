using UnityEngine;

public class SelfDestructor : MonoBehaviour {

    [SerializeField] float timeToDestroy = 5f;

	void Start () {
        Destroy(gameObject, timeToDestroy);
	}
}
