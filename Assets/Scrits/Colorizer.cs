using UnityEngine;

public class Colorizer : MonoBehaviour
{
    public void Awake()
    {
        ApplyRandomColor();
    }

    private void ApplyRandomColor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
