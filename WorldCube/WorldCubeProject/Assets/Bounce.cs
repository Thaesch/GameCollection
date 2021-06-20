using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    private Coroutine bounceRoutine;

    private void Start()
    {
        StartBouncing();
    }

    public void StartBouncing()
    {
        if(bounceRoutine != null)
        {
            StopCoroutine(bounceRoutine);
        }
        bounceRoutine = StartCoroutine(BounceRoutine());
    }

    IEnumerator BounceRoutine()
    {

        float currentScale = transform.localScale.x;

        float steps = 20;
        for(int step = 0; step <= steps; step++)
        {
            // elastic ease
            float t = step / steps;
            float c = (2 * Mathf.PI) / 3;

            transform.localScale = Vector3.one *
                (Mathf.Pow(2, -10 * t) * Mathf.Sin((t * 10 - 0.75f) * c) + 1);

            yield return new WaitForSeconds(0.03f);
        }

        yield return null;
    }

}
