using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody Rb;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        Rb.MovePosition(this.transform.position +(-transform.forward * speed * Time.deltaTime));   
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }

}
