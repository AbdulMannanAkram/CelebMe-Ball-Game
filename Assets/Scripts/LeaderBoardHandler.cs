using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardHandler : MonoBehaviour
{
    public Transform entryContainer;
    public Transform entryTemplate;
    private void Awake()
    {
        entryContainer = transform.Find("HighScoreEntryContainer");
        entryTemplate = entryContainer.Find("HighScoreEntryTemplate");
        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 20f;
        for(int i=0;i<10;i++)
        {
            Transform entryTransform = Instantiate(entryContainer, entryTemplate);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight*i);
            entryTransform.gameObject.SetActive(true);

        }

    }
    
}
