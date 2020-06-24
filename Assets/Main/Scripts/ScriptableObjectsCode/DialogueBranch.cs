using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "Branch", menuName = "CustomObject/Dialogue/Branch")]
public class DialogueBranch : ScriptableObject
{

    public string DialogueID = "";
    public List<string> DialogueLines;
    public List<DialogueResponse> ResponseOption;

}
