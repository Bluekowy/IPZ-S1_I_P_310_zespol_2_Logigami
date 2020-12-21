using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class LevelGrid
{
    private Vector2Int brickGridPosition;
    public static int NO_BRICKS = 3;
    private const int xBORDER = 4;
    private const int yBORDER = 4;
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
        int i, j;

        //array to store previous positions of a gameobject
        Vector2Int[] brickCoordinates = new Vector2Int[NO_BRICKS];

        brickGridPosition = new Vector2Int(UnityEngine.Random.Range((int)x_min, (int)x_max), UnityEngine.Random.Range((int)y_min, (int)y_max));

        //save first coordinates for brick gameobject
        brickCoordinates[0] = brickGridPosition;

        //reserve enough memory to store 
        bool far_enough_OX;
        bool far_enough_OY;


        for (i = 1; i < 3; i++)
        {
            j = i - 1;
            COMPARE:
            brickGridPosition = new Vector2Int(UnityEngine.Random.Range((int)x_min, (int)x_max), UnityEngine.Random.Range((int)y_min, (int)y_max));

            //if new brick's cooredinates are further than specified border
            far_enough_OX = Math.Abs(brickGridPosition.x - brickCoordinates[j].x) > xBORDER;
            far_enough_OY = Math.Abs(brickGridPosition.y - brickCoordinates[j].y) > yBORDER;

            //save next brick coordinates if conditions are met
            if (far_enough_OX && far_enough_OY)
            {
                if (j > 0)
                {
                    j--; goto COMPARE;
                }
                else
                    brickCoordinates[i] = brickGridPosition;
            }
            else
            {
                brickCoordinates[i].x = (brickGridPosition.x - xBORDER);
                brickCoordinates[i].y = (brickGridPosition.y + yBORDER);
            }
        }

        //loop to create gameobjects with proper coordinates
        for (i = 0; i < NO_BRICKS; i++) 
        {
            GameObject brickGameObject = new GameObject("Brick", typeof(SpriteRenderer));
            brickGameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.instance.brickSprite;
            brickGameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Front";
            brickGameObject.transform.position = new Vector3(brickCoordinates[i].x, brickCoordinates[i].y);
            BoxCollider2D boxCollider = brickGameObject.AddComponent<BoxCollider2D>();
            boxCollider.isTrigger = true;
        }
    }
}

