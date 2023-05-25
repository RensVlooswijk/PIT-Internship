# Research Document Whisper

## Introduction

OpenAI's Whisper is an Automatic Speech Recognition (ASR) system that converts spoken audio files into text. To see if I could use whisper to create a dynamic NPC which you can talk to I researched whisper and its API.

## Understanding Whisper

Whisper is an ASR system that uses the Listen, Attend, and Spell (LAS) architecture. It uses AI to understand what is being said in real-time. It works very well and is used in tons of products that are used every day. For example for the subtitles in YouTube. These are auto generated using whispers. The main selling point for me is the fact that it is multilingual. This means it also understands Dutch.

## How to use Whisper

Whisper has an API which I can send audio files to which will the get transcribed into text and return. To use this to create a conversational NPC I would start a voice recording when the player starts talking (by setting a mic threshold) and end it when he stops speaking. I would then send this audio file to the API to get it as a text file. This text file can then be used in several ways. One way would be to send this text file to another AI API, like ChatGPT, to get an answer. I could Also write my own logic to check for certain keywords which would then trigger a certain response.

## Problems with whisper
Whisper works very well and can be used to create a proper dynamic conversational NPC. The main problem however would be its speed. Not Whispers speed on its own, since whisper itself is very fast. But the speed of other parts used with this method. For example the audio file, it needs to be saved and sent which takes some time. Only a few seconds but that it long enough for a conversation to sound unnatural.

## Conclusion

Whisper is a great and powerful ASR system that can be used to create conversational NPCs. By integrating Whisper with generative large language models, and text to speech tools, you can build an interactive NPC. However you should keep in mind the speed tradeoff of this method.

1.  Whisper documentation: [https://openai.com/research/whisper](https://openai.com/research/whisper)

#### Return to [Documents](../Documents)
#### Return to [Portfolio](../README.md)
