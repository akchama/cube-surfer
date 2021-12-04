using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] 
    private float moveForwardSpeed;

    [SerializeField] 
    private float horizontalMoveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * horizontalMoveSpeed * Time.deltaTime;
        this.transform.Translate(horizontalAxis, 0, moveForwardSpeed * Time.deltaTime);
    }
}
