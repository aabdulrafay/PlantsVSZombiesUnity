using UnityEngine;

public class PlantSelector : MonoBehaviour
{
    public float moveAmount = 0.5f;
    public GameObject plantPrefab;

    void Update()
    {
        // movement
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(moveAmount, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-moveAmount, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, moveAmount, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -moveAmount, 0);
        }

        // place plant on ENTER
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(plantPrefab, transform.position, Quaternion.identity);
        }
    }
}