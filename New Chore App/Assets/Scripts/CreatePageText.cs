using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Database;
using Firebase;
using Firebase.Unity.Editor;


public class CreatePageText : MonoBehaviour {
	public InputField inputFieldName;
	public Text TextName;
	public InputField inputFieldDescrip;
	public Text TextDescrip;
	public InputField inputTimeNeeded;
	public Text TextTimeNeeded;
	public InputField inputFieldDueDate;
	public Text TextDueDate;
	public InputField inputFieldAddtionalNotes;
	public Text TextAddionalNotes;

	
	public void CopyText()
	{
		TextName.text = inputFieldName.text;
		TextDescrip.text = inputFieldDescrip.text;
		TextTimeNeeded.text = inputTimeNeeded.text;
		TextDueDate.text = inputFieldDueDate.text;
		TextAddionalNotes.text = inputFieldAddtionalNotes.text;


	}
}
