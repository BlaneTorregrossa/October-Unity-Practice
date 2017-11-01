//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GeneratePattern : MonoBehaviour
//{

//    public GameObject cube;

//    public Vector2 grid;
//    public Vector2 counter;
//    public List<Vector2> cubes = new List<Vector2>();
//    public Vector3 objectPos;
//    public float gapScale;


//    void Start()
//    {
//        if (gapScale >= 1.0f)
//        {
//            gapScale = 1;
//        }
//    }

//    void Update()
//    {
//        GenGrid();
//    }


//    void GenGrid()
//    {
//        if (grid.x >= 5 || grid.y >= 5)
//        {
//            counter.x = 0; counter.y = 0;
//        }

//        else
//        {
//            while (grid.x != counter.x)
//            {
//                cubes.Add(grid);
//                grid.x++;
//                objectPos += new Vector3(1, 0, 0) * gapScale;
//                Instantiate(cube).transform.position = objectPos;
//            }

//            while (grid.x == counter.x)
//            {
//                cubes.Add(grid);
//                grid.y++;
//                objectPos += new Vector3(0, 0, 1) * gapScale;
//                Instantiate(cube).transform.position = objectPos;
//                if (counter.y == 5 && counter.x == 5)
//                {
//                    break;
//                }

//            }
//        }
//    }

//}
