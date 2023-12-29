
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLittleBrother: MonoBehaviour
{
    // Assign the scene name you want to load in the Unity Editor
    public string sceneToLoad;

    private void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Raycast from the mouse position into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits the button
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // Load the specified scene
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}