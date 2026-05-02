using UnityEngine;

public class PlantShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 bulletOffset = new Vector3(0.5f, 0, 0);
    public float shootTime = 2f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= shootTime)
        {
            Shoot();
            timer = 0f;
        }
    }

    void Shoot()
    {
        Vector3 pos = transform.position + bulletOffset;
        Instantiate(bulletPrefab, pos, Quaternion.identity);
    }
}