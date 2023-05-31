# **PIT-Internship**
![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/pit_logo_blokje.png)

##  Portfolio HBO-ICT
### Fontys Hogeschool

![fontys-39-logo-png-transparent (Smaller)](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/fontys-39-logo-png-transparent%20(Smaller).png)

| Student + Company Info | |
| ------------- | ------------- |
| Student Name:  | Rens Vooswijk  |
| Student Nummer  | 466388  |
| Project Period | 6-02-2023 - 13-06-2023|
| Company Name | ROC Tilbrug |
| Company Department | Practoraat Interactieve Technologie |
| Adress | Locomotiefboulevard 101-119, 5041SE Tilburg |
| Company Supervisor | Erdinc Sacan |
| School Supervisor | Lisette Overkamp-Penterman |

## Table of Contents

- [The Assignment](#the-assignment)
- [Research Questions](#research-questions)
     - [Main question](#main-question)
     - [Sub-Question-1](#1)
     - [Sub-Question-2](#2)
     - [Sub-Question-3](#3)
     - [Sub-Question-4](#4)
- [Learning Outcomes](#learning-outcomes)
     - [Professional duties](#1-professional-duties)
     - [Situation-orientation](#2-situation-orientation)
     - [Future-Oriented Organisation](#3-future-oriented-organisation)
     - [Investigative Problem Solving](#4-investigative-problem-solving)
     - [Personal Leadership](#5-personal-leadership)
     - [Targeted Interaction](#6-targeted-interaction)
- [Built With](#built-with)
- [Features](#features)
- [Contact](#contact)
- [Acknowledgements](#acknowledgements)

## The Assignment
![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/csm_pit-visual_41fefac88a.png)

### Context

Practoraat interactieve technologie is an institution within ROC Tilburg that focuses on interactive technology. The company provides education and training in various fields related to technology, including virtual and augmented reality. Rudy, my stakeholder, and client, is a Dutch teacher at ROC Tilburg for refugee students. The reason for the assignment is that the students of the Dutch teacher have trouble speaking Dutch. They practice this by having conversations with each other, but the teacher needs to be present to correct and help them. This makes it impossible for multiple people to practice at the same time. A VR would help students practice conversations on their own. Since they could practice at home, and it is more interesting. The students have also had a previous VR experience which was received very well.

### Goal of the project
The goal of the project is to provide a virtual environment for students to practice their Dutch language skills in a restaurant setting. The problem that needs to be solved is that students require a teacher's presence to correct them during their language practice sessions. This results in limited opportunities for multiple students to practice speaking Dutch at the same time. The desired situation is to have a virtual environment where students can practice their language skills on their own and receive feedback in real-time.

The benefits of the project include improved language skills, increased confidence while speaking, and the ability to practice speaking Dutch anytime and anywhere. The VR restaurant game will offer students the possibility of having realistic conversations with a virtual waiter and provide an immersive learning experience. The product or project result will offer the capability of practicing language skills in a virtual environment and provide the facility of real-time 

### The Assignemnt
Develop a virtual reality game to teach Dutch language to refugees at ROC Tilburg, improving language proficiency, engagement, motivation, and success, aging 18 to 50.

## Research Questions

### Main Question: 
> How effective is virtual reality technology in teaching Dutch language to the students, and what are the best practices for designing and developing a virtual reality game for this purpose?

A lot of research has been done with the goal of answering a similar question. Because from the moment VR headsets were publically available people have seen its potention in education. But for this specific use-case there is no concrete answer. This is why I made a prove of concept and a minimal viable product, To see if the refugee students of "het schakelcollege" would benefit from using virtual reality in their education. And my answer is Yes, it helps. Atleast the MVP I made. The students really enjoyed it and were really engaged. The only problem with my research is that it is a combination of both VR and AI. Because in this case I am not 100% sure the VR was contributing a lot or if it was all by the game/AI itself.

#### 1.	
> What is the current state of research on the use of virtual reality technology in language learning, and how does it compare to traditional language learning methods in terms of >effectiveness and engagement?

As I said before there as been a lot of research papers about VR in education. 

### 2.	
> What are the specific challenges and considerations when using virtual reality technology for language learning, particularly for the students?

### 3.	
> How can we evaluate the effectiveness of the virtual reality game in terms of language proficiency and engagement, and what are the best practices for gathering feedback from the students?

### 4.	
> What are the key steps and best practices for creating a successful proof of concept for a new product or technology?

[Return to table of contents](#table-of-contents) 

## Learning Outcomes

To see more detailed / explained versions of the learning outcomes check out [Learning Outcomes Explained](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/Learning%20Outcomes%20Explained.md#learning-outcomes-explained)

### 1. Professional Duties
> You carry out the professional duties on a junior bachelor level resulting in professional products in line with the IT-area you are working in.
> Professional duties on a junior bachelor level = All or a subset of the activities Analysis, Design, Realize, Advise, Manage & Control. As a reference use: 1) the HBO-I framework on proficiency level 2, 2) the level as >required in OE3 or OE4

I have actively worked on this learning outcome, and I have categorized it into different aspects:

#### Analysis
For the analysis part of my professional duties I started by creating a [project plan](Project Plan) which included multiple aspects of preparation like my requirements"

![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/Requirements.png)

And an idea of the finished product:

![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/EndProductTree.png)

#### Realize
To see my realization of the project you can of course see the entire project within this GitHub page. But for my portfolio I will give a short summary of the things I have done.
It starts with the multiple options I had to realize the project. Check out this link [too see all my research](/Documents) . But when I started with this project I found a tool called Inworld.Ai. which I then used to create a demo scene.

![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/InworldAIDemoPhoto.png)

However this was not optimal as a final product as you can read in my [inworld.ai research](Documents/InworldAi.md) . So I set out to find a different method. Which ended up being a combination of different API's.
It works as followed: When the player starts to speak I start an audio recording which ends when the players stops speaking. I then save this file and send it to the [Whisper API](Docuements/Whisper.md) which transcribes what is said. This API then sends back a text file that I in turn send to the [ChatGPT API](Documents/ChatGPT%20API.md) . This then formulates an answer based on how I prompted the GPT chat beforehand. Finally I will send this answer to the [11Labs API](Documents/11Labs.md) which will speak the text in a voice to my choosing.

![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/StartRecordingCode.png)

This works but there are some drawbacks as well like the time it takes to get a spoken response. This is why I made a startup scene where you can select which version you would like to use

![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/MenuScene.png)

This way the user can choose on their own which fits best for their use case.

#### Advice
As for the advice, I receive weekly feedback from my stakeholder and school assessor. Which is very useful. Furthermore whenever I was not sure or have a question about something I made I went to other students and my internship coordinators.
Also, when I hand something in for school I received feedback which I then implemented before I handed it in again.

![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/FeedbackLogProjectPlanv2.png)

#### Manage & Control 
Finally for the manage and control parts of my professional duties I have done several things. The first being a project plan. At the start of my internship I created multiple iterations of a project plan. I also kept track of my progress using Trello in combination with the Agile work methods.

![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/TrelloBacklog.png)![image](https://github.com/RensVlooswijk/PIT-Internship/blob/Dev/PortfolioAssets/TrelloDone.png)

And lastly I used GitHub as my version control tool. Whenever I added something new I pushed it to my repository to keep track.

[Return to table of contents](#table-of-contents) 

### 2. Situation Orientation
> You apply your previously acquired knowledge and skills in an authentic context to deliver relevant results for the project and company.

For my situation orientation I have applied a lot of knowledge and skills that I aquired in previous semesters. In semester 3 for example, we learned what an API was and how to use them. I used this knowledge to create the dynamically layered method using the [whisper](/Documents/Whisper.md), [ChatGPT](/Documents/ChatGPT%20API.md) and [11labs](/Documents/11Labs.md) API's. 


Previous acquired knowledge 
(one page design) 
(design challenge)
everything unity
API's (semester 3)

[Return to table of contents](#table-of-contents) 

### 3. Future-Oriented Organization
> You explore the organizational context of your project, make business, sustainable and ethical considerations and manage all aspects of the execution of the project.

weekly meetings stakeholder
future internship takeover 
other teachers with interest

[Return to table of contents](#table-of-contents) 

### 4. Investigative Problem Solving
> You take a critical look at your project from different perspectives, identify problems, find an effective approach and arrive at appropriate solutions.

different options of solutions (inworld, Windows speech recognition, whisper + chatgpt + 11labs)

### 5. Personal Leadership 
> You are entrepreneurial around your projects and personal development, you pay attention to your own learning ability and keep in mind what kind of IT professional and/or what type of >positions you aspire to.

offered to help when asked in chat by Erdinc (often)
went to all conferences / events (beursen) VR expo, IT festival, XR event voluntarily

### 6. Targeted Interaction 
> You determine which partners play a role in your project, collaborate constructively with them and communicate appropriately to achieve the desired impact.

Weekly meeting stakeholder
weekly meeting assessor
weekly interactions internship manager
different teachers with relevance into my project
future internship student possible project takeover
multiple Demos for all interns

[Return to table of contents](#table-of-contents) 

### Built With

<!-- TODO: List any MAJOR libraries/frameworks (e.g. React, Tailwind) with links to their homepages. -->

## Features

## Research overview
As seen throughout this portfolio I have conducted mulitple researches with each a corresponding research document.
[Click here to see an overview of all my research documents](/Documents)

## Conclusion

## Review

## Contact

<!-- TODO: Include icons and links to your RELEVANT, PROFESSIONAL 'DEV-ORIENTED' social media. LinkedIn and dev.to are minimum. -->

## Acknowledgements

<!-- TODO: List any blog posts, tutorials or plugins that you may have used to complete the project. Only list those that had a significant impact. Obviously, we all 'Google' stuff while working on our things, but maybe something in particular stood out as a 'major contributor' to your skill set for this project. -->

