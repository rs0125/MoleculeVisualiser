using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class RotateObjectXR : MonoBehaviour
{
    public Vector3 rotationAxis = new Vector3(0, 1, 0);
    public float rotationSpeed = 50f;
    private XRGrabInteractable grabInteractable;
    private bool isGrabbed = false;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    void Update()
    {
        if (!isGrabbed) // Rotate only when not grabbed
        {
            transform.Rotate(rotationAxis * (rotationSpeed * Time.deltaTime));
        }
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        isGrabbed = true; // Stop rotation when grabbed
    }

    void OnRelease(SelectExitEventArgs args)
    {
        isGrabbed = false; // Resume rotation when released
    }
}