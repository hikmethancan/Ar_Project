using UnityEngine;

namespace _Main.Script.Abstract
{
    public interface IDraggable
    {
        void Down();
        void Drag();
        void Up();
        public Camera Camera { get; set; }
    }
}
