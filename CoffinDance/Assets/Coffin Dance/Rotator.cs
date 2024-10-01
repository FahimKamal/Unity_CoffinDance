using UnityEngine;

public class Rotator : MonoBehaviour{
    
    [SerializeField] private float rotateSpeed = 10.0f;
    [SerializeField] private Vector3 rotateDirection = Vector3.up;

    void Update(){
        transform.Rotate(rotateDirection * (rotateSpeed * Time.deltaTime));
    }
}
