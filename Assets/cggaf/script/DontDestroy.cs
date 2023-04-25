using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        Transform parentTransform = this.transform;
        foreach (Transform childTransform in parentTransform)
        {
            DontDestroyOnLoad(childTransform.gameObject);
        }
        DontDestroyOnLoad(parentTransform.gameObject);
    }
}
