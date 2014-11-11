using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
    public float DampTime = 0.1f;
    private Vector3 Velocity = Vector3.zero;
    public Transform Target;

    // LateUpdate вызывается в последнюю очередь
    void LateUpdate() {
        if (Target) {
            Vector3 point = camera.WorldToViewportPoint(new Vector3(Target.position.x, Target.position.y + 0.75f, Target.position.z));
            Vector3 delta = new Vector3(Target.position.x, Target.position.y + 0.75f, Target.position.z) - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;

            transform.position = Vector3.SmoothDamp(transform.position, destination, ref Velocity, DampTime);
        }

    }
}