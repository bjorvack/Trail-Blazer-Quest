using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour
{
    [SerializeField] GameObject player;

    public void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, gameObject.transform.position.y);
    }

    private void OnTriggerEnter() 
    {
        SceneManager.LoadScene(0);
    }
}
