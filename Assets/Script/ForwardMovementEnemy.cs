using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovementEnemy : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame updates
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,speed * Time.deltaTime);
    }
}
