using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    
    [SerializeField] float moveSpeed;
  

    private void Start()
    {
        Destroy(gameObject,7);
    }
    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
