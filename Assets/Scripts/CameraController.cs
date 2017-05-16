using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    // LateUpdate every frame,  runs after all items have been processed in update
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
