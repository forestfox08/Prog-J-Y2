using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
