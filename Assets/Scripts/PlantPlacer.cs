using UnityEngine;

public class PlantPlacer : MonoBehaviour
{
    public GameObject plantPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(plantPrefab, mousePos, Quaternion.identity);
        }
    }
}   