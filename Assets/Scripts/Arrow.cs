using UnityEngine;

public class Arrow : MonoBehaviour
{
    float speed = 5f;
    float lifeTime = 3f;
    Pool pool;

    void Start()
    {
        pool = GameObject.Find("Pool").GetComponent<Pool>();
    }

    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            gameObject.SetActive(false);
            lifeTime = 3f;
            pool.pool.Enqueue(this);
        }
        if (gameObject.activeInHierarchy)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
