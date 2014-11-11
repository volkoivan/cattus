using System.Runtime.InteropServices;
using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
    public float DampTime = 0.1f;
    private Vector3 Velocity = Vector3.zero;
    public Transform Target;

    public int CenterX = 0;

    // LateUpdate вызывается в последнюю очередь
    void LateUpdate() {
        if (Target) {
            Vector3 point = camera.WorldToViewportPoint(new Vector3(CenterX, Target.position.y + 1f, Target.position.z));
            Vector3 delta = new Vector3(CenterX, Target.position.y + 1f, Target.position.z) - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.4f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;

            transform.position = Vector3.SmoothDamp(transform.position, destination, ref Velocity, DampTime);
        }

    }
}