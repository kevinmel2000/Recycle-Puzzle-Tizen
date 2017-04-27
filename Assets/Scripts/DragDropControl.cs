using UnityEngine;

public class DragDropControl : MonoBehaviour
{
    private bool _mouseState;
    private GameObject target;

    Vector3 screenSpace;
    Vector3 offset;

    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hitInfo;
            target = GetClickedObject(out hitInfo);
            if(target != null && (target.tag == "Garbage"))
            {
                _mouseState = true;
                screenSpace = Camera.main.WorldToScreenPoint(target.transform.position);
                offset = target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
            _mouseState = false;
        }

        if(_mouseState && target != null)
        {
            var curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
            var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
            target.transform.position = curPosition;
        }

        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    GameObject GetClickedObject(out RaycastHit2D hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hit = Physics2D.Raycast(ray.origin, ray.direction * 10);

        if(hit)
        {
            target = hit.collider.gameObject;
        }

        return target;
    }
}