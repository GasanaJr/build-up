using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomTransition : MonoBehaviour
{
    public Transform[] roomPositions;
    public Camera mainCamera;
    private int currentRoomIndex = 0;
    public Button nextButton;
    public Button previousButton;

    void Start()
    {
        mainCamera.transform.position = roomPositions[currentRoomIndex].position;
        mainCamera.transform.rotation = roomPositions[currentRoomIndex].rotation;
        UpdateButtonVisibility();
    }

    public void MoveToNextRoom()
    {
        if (currentRoomIndex < roomPositions.Length - 1)
        {
            currentRoomIndex++;
            StartCoroutine(MoveCamera(mainCamera.transform.position, roomPositions[currentRoomIndex].position, 2f));
        }
        UpdateButtonVisibility();
    }

    public void MoveToPreviousRoom()
    {
        if (currentRoomIndex > 0)
        {
            currentRoomIndex--;
            StartCoroutine(MoveCamera(mainCamera.transform.position, roomPositions[currentRoomIndex].position, 2f));
        }
    }

    private IEnumerator MoveCamera(Vector3 startPos, Vector3 endPos, float duration)
    {
        float elapsed = 0;
        while (elapsed < duration)
        {
            mainCamera.transform.position = Vector3.Lerp(startPos, endPos, elapsed/duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        mainCamera.transform.position = endPos;
    }

    private void  UpdateButtonVisibility()
    {
        previousButton.gameObject.SetActive(currentRoomIndex > 0);
        nextButton.gameObject.SetActive(currentRoomIndex < roomPositions.Length - 1);
    }
}
