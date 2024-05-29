using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaskController : MonoBehaviour
{
    [SerializeField] private GameObject flaskexplode;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
    GameObject hitObject = collision.gameObject;
    Quaternion rotatedQuaternion = Quaternion.AngleAxis(90, Vector3.right) * hitObject.transform.rotation;
    if (hitObject.CompareTag("Flask")) 
    {
        hitObject.SetActive(false);
        Instantiate(flaskexplode, hitObject.transform.position, rotatedQuaternion);
    }
}

}
