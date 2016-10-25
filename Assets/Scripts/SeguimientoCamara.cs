using UnityEngine;
using System.Collections;

public class SeguimientoCamara : MonoBehaviour {

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    Camera camera;
    GameObject player;
    Movimiento movimientoPlayer;

    void Start()
    {
        camera = GetComponent<Camera>();
        player = GameObject.FindGameObjectWithTag("Player");
        movimientoPlayer = player.GetComponent<Movimiento>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            if (movimientoPlayer.enElSuelo)
            {
                Vector3 point = camera.WorldToViewportPoint(target.position);
                Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
                Vector3 destination = transform.position + delta;
                transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
            }else
            {
                Vector3 point = camera.WorldToViewportPoint(target.position);
                Vector3 delta = new Vector3(target.position.x, transform.position.y, target.position.z) - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
                Vector3 destination = transform.position + delta;
                transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
            }
        }

    }
}
