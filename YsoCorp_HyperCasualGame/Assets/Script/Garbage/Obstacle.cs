using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private Rigidbody Rb;
    // Start is called before the first frame update
    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Rb.MovePosition(this.transform.position +(-transform.forward * SO_GameManager.ObstaclesManager.ObstaclesSpeed * Time.deltaTime));   
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }

}
