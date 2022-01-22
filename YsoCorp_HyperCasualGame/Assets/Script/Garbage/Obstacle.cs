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
        StartCoroutine(LifeSpan());
    }
    void FixedUpdate()
    {
        if(SO_GameManager.ObstaclesManager.Tier == 0)
        {
            Rb.MovePosition(this.transform.position + (-transform.forward * SO_GameManager.ObstaclesManager.ObstaclesSpeed * Time.deltaTime));
        }
        else
        {
            Rb.MovePosition(this.transform.position + (-transform.forward * SO_GameManager.ObstaclesManager.ObstaclesSpeed * Time.deltaTime * (0.15f * SO_GameManager.ObstaclesManager.Tier +.85f)));
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            SO_GameManager.Instance.GameOver();
        }
    }

    IEnumerator LifeSpan()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
}
