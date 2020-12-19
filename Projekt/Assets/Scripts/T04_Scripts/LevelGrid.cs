using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid
{
    private Vector2Int brickGridPosition;
    private float x_min;
    private float x_max;
    private float y_min;
    private float y_max;

    public LevelGrid(float x_min, float x_max, float y_min, float y_max)
    {
        this.x_min = x_min;
        this.x_max = x_max;
        this.y_min = y_min;
        this.y_max = y_max;

        SpawnBrick();
    }
    private void SpawnBrick()
    {
        int xBorder = 4;
        int yBorder = 7;
        int j;
        //array to store previous positions of a gameobject
        GameObject[] objects_history = new GameObject[3];

        for (int i = 0; i < 3; i++)
        {
            brickGridPosition = new Vector2Int(Random.Range((int)x_min, (int)x_max), Random.Range((int)y_min, (int)y_max));

            GameObject brickGameObject = new GameObject("Brick", typeof(SpriteRenderer));
            brickGameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.instance.brickSprite;
            brickGameObject.transform.position = new Vector3(brickGridPosition.x, brickGridPosition.y);
            objects_history[i] = brickGameObject;
            BoxCollider2D boxCollider = brickGameObject.AddComponent<BoxCollider2D>();
            boxCollider.isTrigger = true;
            if (i >= 1)
            {
                //compare only with the previous one not with all previous ones - wrong
                j = i - 1;
                bool to_close_on_OX = Mathf.Abs(Mathf.Abs(objects_history[i].transform.position.x) - Mathf.Abs(objects_history[j].transform.position.x)) <= xBorder;
                bool to_close_on_OY = Mathf.Abs(Mathf.Abs(objects_history[i].transform.position.y) - Mathf.Abs(objects_history[j].transform.position.y)) <= yBorder;
                if (to_close_on_OX || to_close_on_OY)
                {
                    continue;
                } 
            }
        }
    }
}
