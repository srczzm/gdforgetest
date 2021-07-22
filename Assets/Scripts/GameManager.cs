using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int maxMessages = 10;
    public GameObject chatPanel, textObject;
    public InputField chatBox;

    [SerializeField]
    List<Message> messagesList = new List<Message>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chatBox.text != "")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SendMessageToChat(chatBox.text);
                chatBox.text = "";
            }
        }
        else
        {
            if (!chatBox.isFocused && Input.GetKeyDown(KeyCode.Return))
            {
                chatBox.ActivateInputField();
            }
        }
    }

    public void ClickSendButton()
    {
        if (chatBox.text != "")
        {
            SendMessageToChat(chatBox.text);
            chatBox.text = "";
        }
        else
        {
            chatBox.ActivateInputField();
        }
    }

    public void SendMessageToChat(string text)
    {
        if (messagesList.Count > maxMessages)
        {
            Destroy(messagesList[0].textObject.gameObject);
            messagesList.Remove(messagesList[0]);
        }

        Message newMsg = new Message(text);

        GameObject newText = Instantiate(textObject, chatPanel.transform);

        newMsg.textObject = newText.GetComponent<Text>();
        newMsg.textObject.text = newMsg.text;

        messagesList.Add(newMsg);
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public Text textObject;

    public Message(string s)
    {
        text = s;
    }
}
