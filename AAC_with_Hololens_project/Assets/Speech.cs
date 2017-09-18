using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speech : MonoBehaviour {

    /// <summary>
    /// Tap Test for text to speech. This voice will appear to emanate from the object.
    /// </summary>
    public string texto;
    //private TextToSpeech textToSpeech;

        /*private void Awake()
        {
            textToSpeech = GetComponent<TextToSpeech>();
        }*/

        public void OnInputClicked()
        {
        // Create message
        //var msg = string.Format(
        //"eu", textToSpeech.Voice.ToString());
        // Speak message
        //textToSpeech.StartSpeaking(msg);
            TextToSpeechManager voice = new TextToSpeechManager();
            voice.SpeakText(texto);
    }
    
}
