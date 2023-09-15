using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float Speed = 10f;
    [SerializeField] GameManager Manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Speed, 0)*Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.IncreaseScore(10);
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
