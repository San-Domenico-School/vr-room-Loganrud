using UnityEngine;

public class FlaskExplodeController : MonoBehaviour
{
    [SerializeField] private GameObject center;
    [SerializeField] private float forceMagnitude;

    private Rigidbody rb;
    private Vector3 forceDirection;
    private Vector3 centerPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
        centerPosition = center.transform.position;
        forceDirection = (transform.position - centerPosition).normalized;
        Debug.Log("Force Direction: " + forceDirection + "\nCenter Position: " + centerPosition);
        rb.AddForceAtPosition(forceDirection * forceMagnitude, centerPosition, ForceMode.Impulse);
    }
}
