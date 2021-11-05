using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private GameObject cameraObject;
    [SerializeField]
    private float leftLimit;
    [SerializeField]
    private float rightLimit;
    [SerializeField]
    private float topLimit;
    [SerializeField]
    private float botLimit;

    private void Start()
    {
        Application.targetFrameRate = 200;
        StartCoroutine(ChangeCameraPosition());
    }

    private IEnumerator ChangeCameraPosition()
    {
        while (true)
        {
            gameObject.transform.position = new Vector3(
                Mathf.Clamp(cameraObject.transform.position.x, leftLimit, rightLimit),
                Mathf.Clamp(cameraObject.transform.position.y, botLimit, topLimit), 
                -1);
            yield return null;
        }    
    }
}
