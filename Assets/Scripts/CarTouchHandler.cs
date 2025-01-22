using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTouchHandler : MonoBehaviour
{
    public Car car;
    public RoadPositionSO roadPosition;

    void Awake()
    {
        car = GetComponent<Car>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCar();
    }

    private void MoveCar()
    {
        #if UNITY_EDITOR || UNITY_STANDALONE
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            if (mousePosition.x > Screen.width / 2)
            {
                MoveRight();
            }
            else
            {
                MoveLeft();
            }
        }
        #else
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x > Screen.width / 2)
                {
                    MoveRight();
                }
                else
                {
                    MoveLeft();
                }
            }
        }
        #endif
    }

    private void MoveLeft()
    {
        if (car.roadPosition != RoadPosition.LEFT)
        {
            car.roadPosition -= 1;
        }
        Vector3 newPos = new Vector3(roadPosition.positions[(int)car.roadPosition], car.transform.position.y, car.transform.position.z);
        car.transform.position = newPos;
    }

    private void MoveRight()
    {
        if (car.roadPosition != RoadPosition.RIGHT)
        {
            car.roadPosition += 1;
        }
        Vector3 newPos = new Vector3(roadPosition.positions[(int)car.roadPosition], car.transform.position.y, car.transform.position.z);
        car.transform.position = newPos;
    }
}
