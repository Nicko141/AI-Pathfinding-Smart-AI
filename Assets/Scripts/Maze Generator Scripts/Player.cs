using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private MazeCell currentCell;

    public void SetLocation (MazeCell cell) 
    {
        if (currentCell != null) 
        {
            currentCell.OnPlayerExited();
        }
        currentCell = cell;
        transform.localPosition = cell.transform.localPosition;
        currentCell.OnPlayerEntered();
    }

    private void Move (MazeDirection direction) 
    {
        MazeCellEdge edge = currentCell.GetEdge(direction);
        if (edge is MazePassage) 
        {
            SetLocation(edge.otherCell);
        }
    }

    private void Update () 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            Move(MazeDirection.North);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            Move(MazeDirection.East);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            Move(MazeDirection.South);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            Move(MazeDirection.West);
        }
    }
}
