using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup_ : MonoBehaviour
{
    public Vector3 spinRotationSpeed = new Vector3(0, 180, 0);
    AudioSource pickupSource;
    private void Awake()
    {

        pickupSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (pickupSource)
            AudioSource.PlayClipAtPoint(pickupSource.clip, gameObject.transform.position, pickupSource.volume);
    }
    private void Update()
    {
        transform.eulerAngles += spinRotationSpeed * Time.deltaTime;
    }
}
