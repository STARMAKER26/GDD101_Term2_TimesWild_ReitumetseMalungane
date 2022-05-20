using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7f;


    Vector2 moveInput;


    Rigidbody2D _myRigidbody;



    // Start is called before the first frame update
    void Start()
    {
        // _myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Fly();
    }

    // void PhysicUpdate()
    // {
    //     _myRigidbody.MovePosition(_myRigidbody.position * moveSpeed * Time.fixedDeltaTime);
    // }


    void Fly()
    {
        Vector3 delta = moveInput * moveSpeed * Time.deltaTime;
        Vector2 newPos = new Vector2();
        transform.position = newPos;
        Debug.Log(newPos);
    }

    void OnFly(InputValue value)
    {
        Debug.Log("move");
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
}
