using _Main.Script.Abstract;
using UnityEngine;

namespace _Main.Script.Concrete
{
    public class InputControl : MonoBehaviour
    {
        private IDraggable _draggable;
        [SerializeField] private new Camera camera;
        private RaycastHit _hit;
        

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log($"{Input.mousePosition}");
                Debug.Log(camera);
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out _hit))
                {
                    if(_hit.collider.TryGetComponent(out _draggable))
                        _draggable.Down();
                }
            }
            if(Input.GetMouseButton(0))
                _draggable?.Drag();
            if (Input.GetMouseButtonUp(0))
            {
                _draggable?.Up();
                _draggable = null;
            }
        }
    }
}