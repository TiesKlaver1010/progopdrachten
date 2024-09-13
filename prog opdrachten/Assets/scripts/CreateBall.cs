using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject Ball;
    private void createBall()
    {
        Instantiate(Ball);
    }
    private float elapsedtime = 0f;
    void Update()
    {
        elapsedtime += Time.deltaTime;
        if (elapsedtime > 1f)
        {
            createBall();
            elapsedtime = 0f;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    private void createBall(Color c)
    {
        GameObject ball = Instantiate(Ball);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);
    }
}