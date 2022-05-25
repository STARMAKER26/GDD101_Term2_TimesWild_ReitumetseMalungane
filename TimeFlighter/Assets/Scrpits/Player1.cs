using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;


    Vector2 moveInput;


    Rigidbody2D _myRigidbody;



    // Start is called before the first frame update
    void Start()
    {
        _myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Fly();
         _myRigidbody.MovePosition(_myRigidbody.position * moveSpeed * Time.fixedDeltaTime);
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
