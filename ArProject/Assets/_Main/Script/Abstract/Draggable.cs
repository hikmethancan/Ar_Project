using System;
using UnityEngine;

namespace _Main.Script.Abstract
{
    public class Draggable : MonoBehaviour,IDraggable
    {
        public Camera Camera { get; set; }




        public void Down()
        {
            transform.position = GetMouseWorldPos();
        }

        public void Drag()
        {
            transform.position = GetMouseWorldPos();
        }

        public void Up()
        {
            Debug.Log("Up");
        }


        private Vector3 GetMouseWorldPos()
        {
            return Camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        }
    }
}
