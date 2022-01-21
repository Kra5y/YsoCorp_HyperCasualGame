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
        if(Delay == 0)
        {
            CanRotate = true;
        }
        else
        {
            StartCoroutine(DelayRotation());
        }
    }

    private void Update()
    {
        if (CanRotate)
        {
            transform.Rotate(0, 0, Angle * Time.deltaTime);
        }
    }

    IEnumerator DelayRotation()
    {
        yield return new WaitForSeconds(Delay);
        CanRotate = true;
    }

}
