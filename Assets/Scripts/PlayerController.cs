using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject _player;
    public float playerSpeed;
    private float horizontalInput;
    private float verticalInput;
    private float xRange = 15.0f;
    private float zRangeTop = 15.0f;
    private float zRangeBot = 0.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        zRangeTop = 15.0f;
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

        if (_player.transform.position.z > zRangeTop)
        {
            _player.transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, zRangeTop);
        }

        if (_player.transform.position.z < zRangeBot)
        {
            _player.transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, zRangeBot);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        _player.transform.Translate(Vector3.right * horizontalInput * playerSpeed * Time.deltaTime);

        verticalInput = Input.GetAxis("Vertical");
        _player.transform.Translate(Vector3.forward * verticalInput * playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) )
        {
            // Lunch a projectile form the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
