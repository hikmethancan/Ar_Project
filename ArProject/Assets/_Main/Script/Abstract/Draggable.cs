using UnityEngine;

namespace _Main.Script.Abstract
{
    public class Draggable : MonoBehaviour,IDraggable
    {
        public void Down()
        {
            Debug.Log("Down");
        }

        public void Drag()
        {
            Debug.Log("Dragging");
        }

        public void Up()
        {
            Debug.Log("Up");
        }
    }
}
