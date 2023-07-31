using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private int movementPattern;
    // TODO: figure out how to select and move enemy GameObject

    // Start is called before the first frame update
    void Start()
    {
        // pick one of a set of movement patterns
        movementPattern = Random.Range(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (movementPattern == 0)
        {
            LineAttack();
        }
        else
        {
            SineAttack();
        }
    }

    void LineAttack()
    {
        // TODO: move enemy in a line ----->
    }

    void SineAttack()
    {
        // TODO: move enemy in a wave /\/\/\/\>
    }
}
