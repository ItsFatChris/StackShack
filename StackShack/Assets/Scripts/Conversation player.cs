using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversationplayer : MonoBehaviour {

    public Conversation conversation;

    public Text text;
    public Image image;

    public int currentMessageNumber;
	
	void Start () {
        currentMessageNumber = 0;
        SetMessage(currentMessageNumber);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetMessage(currentMessageNumber++);
        }
	}

    private void SetMessage(int messageNumber)
    {
        text.text = conversation.messages[messageNumber].message;
        SetSpeakerPicture(conversation.messages[messageNumber].speaker);
    }

    private void SetSpeakerPicture(int speaker)
    {
        switch (speaker)
        {
            case 0:
                image.material.color = Color.red;
                break;
            case 1:
                image.material.color = Color.blue;
                break;
            default:
                image.material.color = Color.yellow;
                break;

        }
    }
}
