using UnityEngine;
using System.Collections;

public class SeguimientoCamara : MonoBehaviour {

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    new Camera camera;
    GameObject player;
    MovimientoCharacterController movimientoPlayer;

    void Start()
    {
        camera = GetComponent<Camera>();
        player = GameObject.FindGameObjectWithTag("Player");
        movimientoPlayer = player.GetComponent<MovimientoCharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {

            Vector3 point = camera.WorldToViewportPoint(target.position);
            Vector3 delta;

            if (movimientoPlayer.enSuelo)
            {
                delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            }
            else if ((camera.WorldToViewportPoint(target.position).y <= 0))
            {
                Debug.Log("toco fondo");
                delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 1f, point.z));
            }
            else 
            {
                delta = new Vector3(target.position.x, transform.position.y, target.position.z) - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            }

            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
    }
}
