using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterControll : MonoBehaviour
{
    public float _speed = 5;
    private Rigidbody _rb;

    private float x = 0f;
    private float z = 0f;

    private int _completedLvls;

    [SerializeField] private Transform _groundCheck;
    private bool _isGrounded;
    private bool _canJump = true;
    private float _jumpHeight = 13f;

    private void Start()
    {
        _completedLvls = PlayerPrefs.GetInt("CompletedLvls", 0);
        //PlayerPrefs.SetInt("CompletedLvls", 0); //если что обнулить пройденные лвл
        _rb = GetComponent<Rigidbody>();

        if (_completedLvls == 1) //if lvl 1 completed
        {
            this.transform.localScale = new Vector3(2f, 2f, 2f);
        }
        else if (_completedLvls == 2) //if lvl 2 completed
        {

        }
        else if (_completedLvls == 3) //if ...
        {
            
        }
        else if (_completedLvls == 4)
        {
            
        }
        else if (_completedLvls == 5) //esli lvl5 budet kak finalniy
        {
            
        }
    }


    private void Update()
    {
        if (_completedLvls > 0)
        {
            Jump();
        }   

        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (_completedLvls > 0)
        {
            GroundCheck();
        }  
        
        
        Vector3 move = new Vector3(x * _speed, _rb.velocity.y, z * _speed);

        _rb.velocity = move;
        //transform.Translate(move * Time.deltaTime, Space.World);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canJump && _isGrounded) // 
        {
            _rb.AddForce(Vector3.up * _jumpHeight, ForceMode.VelocityChange);
            StartCoroutine(CanJump());
        }
    }

    private void GroundCheck()
    {
        Collider[] colliders = Physics.OverlapSphere(_groundCheck.position, 0.2f);
        _isGrounded = colliders.Length > 1;
    }

    IEnumerator CanJump()
    {
        _canJump = false;
        yield return new WaitForSeconds(1f);//jump reload time
        _canJump = true;
    }
}
