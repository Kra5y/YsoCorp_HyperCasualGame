using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    [SerializeField] float Angle;
    [SerializeField] float Delay;
    bool CanRotate = false;

    private void Awake()
    {
        if (SO_GameManager.ObstaclesManager.Tier == 0)
        {
            return;
        }
        if (Delay == 0)
        {
            CanRotate = true;
        }
        else if (Delay != 0)
        {
            StartCoroutine(DelayRotation());
        }
    }

    private void Update()
    {
        if (CanRotate)
        {
            transform.Rotate(0, 0, Angle * Time.deltaTime * (.5f * SO_GameManager.ObstaclesManager.Tier + .5f));
        }
    }

    IEnumerator DelayRotation()
    {
        yield return new WaitForSeconds(Delay);
        CanRotate = true;
    }

}
