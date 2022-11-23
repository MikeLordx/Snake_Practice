using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGrow : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private GameObject obj;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("SnakeManager");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _player.GetComponent<SnakeManager>().AddBodyParts(obj);
            _player.GetComponent<SnakeManager>().AddBodyParts(obj);
            Debug.Log("2");
            Destroy(gameObject);
        }
    }
}
