using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sofia : MonoBehaviour
{
    [SerializeField] private float perspectiveScale;
    [SerializeField] private float scaleRatio;

    // Update is called once per frame
    void Update()
    {
        MudarPerspectiva();
    }

    private void MudarPerspectiva()
    {
        Vector3 scale = transform.localScale;
        scale.x = perspectiveScale * (scaleRatio - transform.position.y);
        scale.y = perspectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;
    }
}
