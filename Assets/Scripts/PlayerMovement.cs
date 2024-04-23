using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController Controller;
    public float Speed = 10f;
    public float Gravity = -10f;
    Vector3 Velocity;
    public Transform GroundCheck;
    public float GroundDistance;
    public LayerMask GroundMask;
    bool IsGrounded;
    public float CrouchSpeed, NormalHeight, CrouchHeight;
    bool Crouching;
    public Transform Player;
    public Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Crouching = !Crouching;
        }

        if (Crouching == true)
        {
            Controller.height = Controller.height - CrouchSpeed * Time.deltaTime;
            if (Controller.height <= CrouchHeight)
            {
                Controller.height = CrouchHeight;
            }
        }

        if (Crouching == false)
        {
            Controller.height = Controller.height + CrouchSpeed * Time.deltaTime;
            if(Controller.height < NormalHeight)
            {
                Player.gameObject.SetActive(false);
                Player.position = Player.position + Offset * Time.deltaTime;
                Player.gameObject.SetActive(true);
            }
            if(Controller.height >= NormalHeight)
            {
                Controller.height = NormalHeight;
            }
        }

        IsGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);

        if (IsGrounded && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        Controller.Move(move * Speed * Time.deltaTime);
        Velocity.y += Gravity * Time.deltaTime;
        Controller.Move(Velocity * Time.deltaTime);
    }
}
