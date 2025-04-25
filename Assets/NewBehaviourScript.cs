using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] private Transform t;
    [SerializeField] private GameObject go;
    [SerializeField] private Rigidbody rb;
    [Header("Values")]
    [SerializeField][Range(0,20)] private float F = 5.0f; 
}
