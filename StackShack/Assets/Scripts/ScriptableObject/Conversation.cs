using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Conversation", menuName ="Dialog")]

public class Conversation : ScriptableObject {
    [Serializable]

    public class ConversationMessage
    {
        public int speaker;
        [Multiline]
        public string message;
    }

    public List<ConversationMessage> messages;
	
}
