using UnityEngine;

public class Teleport : MonoBehaviour
{

    [SerializeReference] GameObject otherTeleportObject;
    public bool triggered;


    private void OnTriggerEnter(Collider other)
    {
        if (!triggered)
        {
        other.transform.position = new Vector3(otherTeleportObject.transform.position.x, other.transform.position.y, otherTeleportObject.transform.position.z);

            otherTeleportObject.GetComponent<Teleport>().triggered =true;
            var playerHealth = other.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(15f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        triggered = false;
    }
}
