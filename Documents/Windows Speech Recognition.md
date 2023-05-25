# Introduction

Windows Speech Recognition is a built-in feature of Windows that allows users to control their computer using voice commands. This feature can be integrated into Unity to create conversational NPCs that can understand and respond to user voice input.

# Setting up Windows Speech Recognition

To use Windows Speech Recognition in Unity, you first need to set it up on your computer. Here's how to do it:

1.  Open the Start menu and search for "Speech Recognition".
2.  Click on "Start Speech Recognition".
3.  Follow the on-screen instructions to set up your microphone and train your computer to recognize your voice.
4.  Once set up, Windows Speech Recognition will be running in the background, ready to receive voice commands.

# Integrating Windows Speech Recognition in Unity

Once Windows Speech Recognition is set up on your computer, you can integrate it into Unity to create conversational NPCs. Here's how to do it:

1.  Create a new Unity project or open an existing one.
2.  Create a new GameObject and add an AudioSource component to it.
3.  Create a new C# script and attach it to the GameObject.
4.  In the script, use the Windows Speech Recognition API to listen for voice commands and trigger specific actions or responses based on those commands.

Here's an example script that listens for voice commands and responds with a pre-defined message:

csharpCopy code
![[Speech Recognition code.png]]
In this example, the script listens for three voice commands ("hello", "how are you", "goodbye") and responds with a pre-defined audio clip.

# Conclusion

Integrating Windows Speech Recognition into Unity can be a powerful tool for creating conversational NPCs that can understand and respond to user voice input. By using the Windows Speech Recognition API, you can listen for voice commands and trigger specific actions or responses based on those commands. However, it's important to note that the accuracy of Windows Speech Recognition may vary depending on the quality of the microphone and the clarity of the user's speech.