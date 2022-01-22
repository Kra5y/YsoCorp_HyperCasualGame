using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] Vector3 Direction;
    [SerializeField] float Delay;
    [SerializeField] bool AlwaysMove;

    bool canMove;

    private void Awake()
    {
        if (SO_GameManager.ObstaclesManager.Tier == 0 && !AlwaysMove)
        {
            return;
        }
        if (Delay == 0)
        {
            canMove = true;
        }
        else if (Delay != 0)
        {
            StartCoroutine(DelayMove());
        }
    }

    private void Update()
    {
        if (canMove)
        {
            transform.Translate( Direction * Time.deltaTime);
           
        }
    }

    IEnumerator DelayMove()
    {
        yield return new WaitForSeconds(Delay);
        canMove = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(this.transform.position, Direction);
    }
}
