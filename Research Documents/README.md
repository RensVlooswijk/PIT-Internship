# Option Research

For my project I found 4 possible solutions/tools that I could use to create a conversational npc.

The first and most prominent was InworldAI.
InworldAI allows you to create and customize characters with personalities and dialogue using AI. These characters can respond to any questions you ask, making them ideal conversation partners. You can import these characters into Unity to create conversational NPCs. However, the tool is currently limited to understanding English. To read more about my Inworld Ai research check out [[InworldAi]].

The next option was [[Wit.Ai]]
Wit.ai is a natural language processing tool that can help create a conversational NPC with the ability to understand and respond to user input. By integrating [[Wit.ai]], the NPC can interpret user intents, extract relevant entities and respond with appropriate actions or dialogue. This makes it possible to create engaging and interactive conversations with the NPC, enhancing the overall user experience. 

Another option would be to use different API's and link them together to create the flow. The best options that I found is creating a voice recording which you can send to the Whisper API, Whisper is a platform made by OpenAi that can transcribe speech to text. Then I would send the text that I get to the ChatGPT API for an answer. And then follow that up by sending the answer to the [11Labs API](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/Research%20Documents/11Labs) to read it in a human voice.
[11labs](/ResearchDocuments/11Labs.md)

The final option was to create it myself completely using the bare bones [[windows speech recognition]]. this would give me more control of the conversation and lets me easily perform actions mid conversation. It would also allow me to give the user feedback on his or her english which would be very helpfull. The main issue with this sollution is that all the conversations would have to be scripted. This would make it way less dynamic and less fun.
