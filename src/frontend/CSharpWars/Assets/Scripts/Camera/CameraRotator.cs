using UnityEngine;

public class CameraRotator : MonoBehaviour
{
  public float RotationsPerMinute = 1.0f;

  public void Update() {
    var yAngle = 6.0f * RotationsPerMinute * Time.deltaTime;
    transform.Rotate(xAngle:0f, yAngle:yAngle, zAngle:0f);
  }
    
}