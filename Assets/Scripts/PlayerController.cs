using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject _player;
    public float playerSpeed;
    private float horizontalInput;
    public float xRange = 15.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        xRange = 15f;
        playerSpeed = 15f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.transform.position.x > xRange)
        {
            _player.transform.position = new Vector3(xRange, _player.transform.position.y, _player.transform.position.z);
        }

        if (_player.transform.position.x < -xRange)
        {
            _player.transform.position = new Vector3(-xRange, _player.transform.position.y, _player.transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        _player.transform.Translate(Vector3.right * horizontalInput * playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) )
        {
            // Lunch a projectile form the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
