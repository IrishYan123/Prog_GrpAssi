using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 20f;
    public GameObject bulletPrefab;
    public Transform firepoint;
    public float bulletspeed = 10f;

    private Rigidbody rb;
    public bool isJumping = false;
    [SerializeField] TMP_Text score;
    [SerializeField] TMP_Text score2;
    public static int  points;
    void Awake()
    {
        score.text = "Score: " + points;
        score2.text = "Score: " + points;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        points = 0;
        Time.timeScale = 1;

    }

    private void Update()
    {
        score.text = "Score: " + points;
        score2.text = "Score: " + points;
        // Player movement
        //  press WASD 
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Jumping
        // press spacebar to jump
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            // Give the sphere a rapid upward velocity
            rb.AddForce(0f, jumpForce, 0f);
            isJumping = true;
        }

        //If the sphere is moving upwards and has a negative velocity (i.e. falling), mark it as no longer jumping
        if (isJumping && rb.velocity.y < 0)
        {
            isJumping = false;
        }

        // Gravity
        //rb.AddForce(Vector3.down * gravity * Time.deltaTime);


        //Player shooting 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, Quaternion.identity);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.velocity = transform.forward * bulletspeed;
        Destroy(bullet, 4f);    //destroy the bullet after 5 sec 
    }
    public void enemykiller()
    {
        points += 1;
        score.text = "" + points;
        score2.text = "" + points;
    }
}