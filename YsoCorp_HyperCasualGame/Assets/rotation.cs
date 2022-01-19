using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0,0,45 * Time.deltaTime);
    }

}
