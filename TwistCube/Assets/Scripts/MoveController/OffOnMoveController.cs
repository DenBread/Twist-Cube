using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffOnMoveController : MonoBehaviour {

	public GameObject left;
	public GameObject right;
	public GameObject rotImg;
	public GameObject tuchImg;
	public MovePlayer player;

    public GameObject mainPanel;
    public GameObject settingsPanel;
	//public bool test;

	public void OffMove()
	{
        tuchImg.SetActive(false);
        player.enabled = true;
        left.SetActive(false);
        right.SetActive(false);
        rotImg.SetActive(true);
    }

    public void OnMove()
    {
        rotImg.SetActive(false);
        player.enabled = false;
        left.SetActive(true);
        right.SetActive(true);
        tuchImg.SetActive(true);
    }

    public void EntrySettings()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void ExitSettings()
    {
        settingsPanel.SetActive(false);
        mainPanel.SetActive(true);
    }
}
