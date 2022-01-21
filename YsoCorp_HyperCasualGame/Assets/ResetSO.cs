using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSO : MonoBehaviour
{
    private void Awake()
    {
        SO_GameManager.Instance.ResetSO();
    }
}
