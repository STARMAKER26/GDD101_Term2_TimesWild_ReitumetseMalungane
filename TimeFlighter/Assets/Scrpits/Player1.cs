using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // [SerializeField] float turnSpeed = 5f; 

     Vector2 moveInput;
     Vector2 mousePos;

    public Rigidbody2D _myRigidbody;
    public Camera cam;


    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody2D>();

    }

   
     void Update()
    {
    
     _myRigidbody.MovePosition(_myRigidbody.position * moveSpeed * Time.fixedDeltaTime);
          
    mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }

 void FixedUpdate() {
     Fly();

         Vector2 lookDir = mousePos - _myRigidbody.position;
        float angle = Mathf.Atan2(lookDir.y,lookDir.x) * Mathf.Rad2Deg ;
        _myRigidbody.rotation = angle;
        
    }

    
 

    void Fly()
    {
        Vector3 delta = moveInput * moveSpeed * Time.deltaTime;
        Vector2 newPos = new Vector2();
        newPos.x = transform.position.x + delta.x;
        newPos.y = transform.position.y + delta.y;
        transform.position = newPos;
        Debug.Log(newPos);
    }

    void OnFly(InputValue value)
    {
        Debug.Log("Fly");
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
   
    


}
