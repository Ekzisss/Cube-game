using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody rb;

    private float x = 0f;
    private float z = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3(x * speed, rb.velocity.y, z * speed);

        rb.velocity = move;
        // transform.Translate(move * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("reset"))
        {
            SceneManager.LoadScene(SceneManager.sceneCount);
        }
    }
}
