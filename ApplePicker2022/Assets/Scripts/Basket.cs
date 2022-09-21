using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{

    public ScoreCounter scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreCounter = scoreGO.GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the mouse from Input
        Vector3 mousePos2d = Input.mousePosition;

        mousePos2d.z = Camera.main.transform.position.z;

        Vector3 mousePos3d = Camera.main.ScreenToWorldPoint(mousePos2d);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3d.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collideWith = coll.gameObject;
        if (collideWith.CompareTag("Apple"))
        {
            Destroy(collideWith);
        }

        scoreCounter.score += 100;
        HighScore.TRY_SET_HIGH_SCORE(scoreCounter.score);
    }
}
