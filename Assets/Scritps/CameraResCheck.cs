using UnityEngine;

public class CameraResCheck : MonoBehaviour
{
    private Camera camera;
    private int width;
    private int height;

    private void Start()
    {
        camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        width = camera.pixelWidth;
        height = camera.scaledPixelHeight;

        Debug.Log($"Width: {width}; Height: {height}.");
    }
}
