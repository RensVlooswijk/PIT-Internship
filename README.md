# **PIT-Internship**
![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/ba547b3b-3439-435d-baee-490ffea84e8d)

##  Portfolio HBO-ICT
### Fontys Hogeschool

![fontys-39-logo-png-transparent (Smaller)](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/8fe01e90-0c82-432f-902b-62310e27a4ac)

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
     - [Sub-Question-1](#2)
     - [Sub-Question-1](#3)
     - [Sub-Question-1](#4)
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
![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/c4c3a80f-3b3b-427b-a6b1-655c95d8fe66)

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

#### 1.	
> What is the current state of research on the use of virtual reality technology in language learning, and how does it compare to traditional language learning methods in terms of >effectiveness and engagement?

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

![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/c1899be9-6667-4ffc-b9b2-ce6355f2486b)

And an idea of the finished product:

![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/2b588c6d-adb0-4748-b693-09e2f8d18dd2)

#### Realize
To see my realization of the project you can of course see the entire project within this GitHub page. But for my portfolio I will give a short summary of the things I have done.
It starts with the multiple options I had to realize the project. Check out this link [too see all my research](/Documents) . But when I started with this project I found a tool called Inworld.Ai. which I then used to create a demo scene.

![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/3713ca74-cb9e-41c0-8a25-414b367dc611)

However this was not optimal as a final product as you can read in my [inworld.ai research](Documents/InworldAi.md) . So I set out to find a different method. Which ended up being a combination of different API's.
It works as followed: When the player starts to speak I start an audio recording which ends when the players stops speaking. I then save this file and send it to the [Whisper API](Docuements/Whisper.md) which transcribes what is said. This API then sends back a text file that I in turn send to the [ChatGPT API](Documents/ChatGPT%20API.md) . This then formulates an answer based on how I prompted the GPT chat beforehand. Finally I will send this answer to the [11Labs API](Documents/11Labs.md) which will speak the text in a voice to my choosing.

![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/bc25da7e-383e-4274-8652-8d82ba9d70bf)

This works but there are some drawbacks as well like the time it takes to get a spoken response. This is why I made a startup scene where you can select which version you would like to use

![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/1d31ddfb-6c0c-44de-9de5-e3bff33761f3)

This way the user can choose on their own which fits best for their use case.

#### Advice
As for the advice, I receive weekly feedback from my stakeholder and school assessor. Which is very useful. Furthermore whenever I was not sure or have a question about something I made I went to other students and my internship coordinators.
Also, when I hand something in for school I received feedback which I then implemented before I handed it in again.

![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/703771de-8e96-4fc4-81d3-e6ae7cf1cea1)

#### Manage & Control 
Finally for the manage and control parts of my professional duties I have done several things. The first being a project plan. At the start of my internship I created multiple iterations of a project plan. I also kept track of my progress using Trello in combination with the Agile work methods.

![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/a12629de-be5d-4d53-9e77-411537387819)![image](https://github.com/RensVlooswijk/PIT-Internship/assets/73878099/f07d5bbd-311e-44af-acf5-ea8f66b13262)

And lastly I used GitHub as my version control tool. Whenever I added something new I pushed it to my repository to keep track.

[Return to table of contents](#table-of-contents) 

### 2. Situation Orientation
> You apply your previously acquired knowledge and skills in an authentic context to deliver relevant results for the project and company.

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

## Research
[Click here to see all my research documents](/Documents)

<!-- TODO: List what specific 'user problems' that this application solves. -->

## Conclusion

## Review

## Contact

<!-- TODO: Include icons and links to your RELEVANT, PROFESSIONAL 'DEV-ORIENTED' social media. LinkedIn and dev.to are minimum. -->

## Acknowledgements

<!-- TODO: List any blog posts, tutorials or plugins that you may have used to complete the project. Only list those that had a significant impact. Obviously, we all 'Google' stuff while working on our things, but maybe something in particular stood out as a 'major contributor' to your skill set for this project. -->

