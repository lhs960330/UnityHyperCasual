using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{   
    [SerializeField] Transform[] children;
    [SerializeField] float scrooSpeed;
    [SerializeField] float offset;

    private void Update()
    {
        for(int i =0; i < children.Length; i++)
        {
            children[i].Translate(Vector2.left * scrooSpeed * Time.deltaTime, Space.World);
            if (children[i].position.x < -  offset)
            {
                Vector2 pos = new Vector2(offset, children[i].position.y);
                children[i].position = pos;
            }
        }
    }
}
