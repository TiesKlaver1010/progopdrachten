using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;

public class CreateBall : MonoBehaviour

{
    public GameObject Ball;

    private float elapsedtime = 0f;
    void Update()
    {
        elapsedtime += Time.deltaTime;
        if (elapsedtime > 1f)
        {
            Vector3 randPos = RandomPosition(-10f, 10f);
            GameObject ball = createBall(RandomColor(), randPos);
            elapsedtime = 0f;
            
        }
    }
    private GameObject createBall(Color c, Vector3 pos)
    {
        GameObject ball = Instantiate(Ball, pos, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);
        return ball;
    }
    private void Start()
    {
        Vector3 randPos = RandomPosition(-10f, 10f);
        for (int i = 0; i < 1000; i++) {
            createBall(RandomColor(), RandomPosition(-10f, 10f));
        }
    }
    private Vector3 RandomPosition(float minPosition, float maxPosition)
    {
        float x = Random.Range(minPosition, maxPosition);
        float y = 0f;
        float z = Random.Range(minPosition, maxPosition);
        Vector3 randPosition = new Vector3(x, y, z);
        return randPosition;
    }
    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        return randColor;
    }

}



