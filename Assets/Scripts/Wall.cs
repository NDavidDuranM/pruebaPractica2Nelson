using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        MoverMuro();

        CheckPosition();
    }

    void MoverMuro()
    {
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
    }

    void CheckPosition()
    {
        if (transform.position.x <= -6f)
        {
            Destroy(this.gameObject);
        }
    }
}
