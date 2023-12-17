using UnityEngine;

public class BouncePad : MonoBehaviour
{
    [Header("Bounce Pad")]
    [Space]
    [Header("Customizable")]
    [Space]
    [SerializeField, Range(0,50)] float bounceForce;

    void OnCollisionEnter(Collision collider){
        Rigidbody body = collider.gameObject.GetComponent<Rigidbody>();
        float force = bounceForce + body.velocity.magnitude;
        body.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}
