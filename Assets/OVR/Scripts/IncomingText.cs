using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IncomingText : MonoBehaviour {
    public int currentTime;
    public GameObject cellPhone;
    public Vector3 temp;
    public int textCount;
    public Text textMessage;
    private string[] questions = new string[] {"Hey, where are you?", "What should we do when you get here?", "Lol it's about time...", "Yeah, that's what they told me yesterday."};
    private string[] correctAnswers = new string[] {"I'm on my way!", "Probably start working on our VR project.", "Is Albert coming over too?", "Sounds good, see you soon then!"};
    private string[] wrongAnswers = new string[] {"I can't wait for the game tomorrow!", "My favorite pizza is pepperoni.", "What's the Earth's diameter?", "I know right, such a good movie!"};
    
 
    // Use this for initialization
    void Start () {
        cellPhone = GameObject.Find("smartphone");
        
        textCount = 0;
        

    }
	
	// Update is called once per frame
	void Update () {
        currentTime = ElapsedTime.timeE;
        
		if (currentTime % 20 == 0)
        {
            cellPhone.transform.position = new Vector3(x: cellPhone.transform.position.x, y: 1.195f, z: cellPhone.transform.position.z);
            textMessage.text = ("New Text Message! Press 'A' To Respond.");
        }

        if (OVRInput.Get(OVRInput.Button.One))
        {
            if (textCount % 2 == 0) {
                textMessage.text = (questions[textCount] + "\n" + "X: " + correctAnswers[textCount] + "\n" + "Y: " + wrongAnswers[textCount]);
            }
            else if (textCount % 2 == 1)
            {
                textMessage.text = (questions[textCount] + "\n" + "X: " + wrongAnswers[textCount] + "\n" + "Y: " + correctAnswers[textCount]);
            }
            
        }

        if (OVRInput.Get(OVRInput.Button.Three) && textCount % 2 == 0)
        {
            cellPhone.transform.position = new Vector3(x: cellPhone.transform.position.x, y: 0.533f, z: cellPhone.transform.position.z);
            textMessage.text = ("");
            textCount++;
        }
        else if (OVRInput.Get(OVRInput.Button.Four) && textCount % 2 == 1)
        {
            cellPhone.transform.position = new Vector3(x: cellPhone.transform.position.x, y: 0.533f, z: cellPhone.transform.position.z);
            textMessage.text = ("");
            textCount++;
        }


    }
}
