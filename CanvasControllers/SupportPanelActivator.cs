using System;
using System.Collections;
using UnityEngine;

public class SupportPanelActivator : MonoBehaviour
{
    public GameObject[] blocks;
    [SerializeField] private GameObject supportPanel;

    private void Awake()
    {
        if (supportPanel != null)
        {
            supportPanel.SetActive(false);
            Array.ForEach(blocks, block => block.SetActive(false));
        }
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(.5f);
        supportPanel.SetActive(true);

        for (int i = 0; i < blocks.Length; i++)
        {
            blocks[i].SetActive(true);
            yield return new WaitForSeconds(2f);

            blocks[i].SetActive(false);

            if (i == blocks.Length - 1)
            {
                supportPanel.SetActive(false);
            }
        }
    }
}
