using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    [Header("Rigidbody")]
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 0, 7 * Time.deltaTime);
        Time.timeScale += Time.fixedDeltaTime * 0.01f;

        rb.velocity += transform.rotation * (Vector3.right * Input.GetAxisRaw("Horizontal") * 10f * Time.deltaTime);
        rb.velocity += transform.rotation * (Vector3.up * Input.GetAxisRaw("Vertical") * 10f * Time.deltaTime);

        float clampedX = Mathf.Clamp(transform.position.x, -30f, 30f);
        float clampedZ = Mathf.Clamp(transform.position.z, -30f, 30f);

        transform.position = new Vector3(clampedX, 0, clampedZ);
    }


    void OnCollisionEnter(Collision collision)
    { 
        SceneManager.LoadScene(0);
    }
}
