using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "Response", menuName = "CustomObject/Dialogue/Response")]
public class DialogueResponse : ScriptableObject
{

    public string Text;
    public DialogueBranch nextBranch;

}