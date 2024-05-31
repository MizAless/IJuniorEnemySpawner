using UnityEngine;

public class GizmosMarker : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        float sphereRadius = 0.2f;
        float red = 0;
        float green = 0;
        float blue = 1;
        float alpha = 0.3f;

        Gizmos.color = new Color(red, green, blue, alpha);
        Gizmos.DrawSphere(transform.position, sphereRadius);
    }
}
