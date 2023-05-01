using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilReset : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 resetPosition = new Vector3(0, 10, 0);

    private void Update()
    {
        if (transform.position.y < 0)
        {
            transform.position = resetPosition;
        }
    }

    public void reset()
    {
        transform.position = resetPosition;
    }
}
