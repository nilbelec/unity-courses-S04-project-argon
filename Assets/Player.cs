using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Tooltip("In ms^-1")] [SerializeField] float xSpeed = 4f;
    [Tooltip("In m")] [SerializeField] float xRange = 6f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float newXPosition = transform.localPosition.x + xOffset;
        newXPosition = Mathf.Clamp(newXPosition, -xRange, xRange);
        transform.localPosition = new Vector3(newXPosition, transform.localPosition.y, transform.localPosition.z);
	}
}
