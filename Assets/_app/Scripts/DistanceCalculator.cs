using TMPro;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    [SerializeField] private Transform targetObject;
    [SerializeField] private Transform canvasTextDistance;
    [SerializeField] private TMP_Text textDistance;

    private Camera _cameraMain;

    private void Start()
    {
        _cameraMain = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var position = targetObject.position;
        var distance = Vector3.Distance(_cameraMain.transform.position, position);

        canvasTextDistance.position = position + new Vector3(0, 0.25f, 0);
        textDistance.text = "" + Mathf.Round(distance * 100f) / 100f +"m away";
    }
}