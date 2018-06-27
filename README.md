## Museum Project Overview

### Intro
The objective of this project was to design a set of displays for various fields and how they are used and evolving in the VR space.  Much of my time with this task was spent deciding what topics I wanted to cover, gathering appropriate visual aids to incorporate, and deciding what audio I might want to add to each of the displays.  For level design, given that the assignment did not call for a goal or "win state", I focused on making the environment open and inviting.      

The topics I decided to cover in my displays were games, creation tools, videos, social technologies, and UI interactions.  I chose these areas both because I wanted to keep my topics broad and because I have personal interest in all of them.  I tried to pick logos and images of common and relevant VR applications to add to the displays so that users have a good idea of what things might currently look like in the topic of interest.  For the audio portion, I decided to record my own narration for each topic.

The majority of my time with this project was spent finding appropriate images, recording audio, and arranging the display areas.  I did write some basic scripts to control the players movement and UI interactions, but it was not a significant investment of time comparably.  Interestingly, I felt a bit like an interior decorator with all the display arraignments, which was not what I expected coming into this project.     


### Outcomes
I decided to go with an art museum style level, as I felt it was very appropriate and I had some assets that matched that style quite well.  I feel that the displays I created do a good job of showing relevant images and examples while keeping with the art museum theme.  The narrations I made took me many iterations of re-writing and re-recording, but I feel that the audio is brief and informative as a result.  I would have liked to add some 3D models to the displays to fill out more space and add more items to look at while listening to the narrations, but relevant props were too specific to easily find.  

#### Demo Video
[![Museum Demo](https://github.com/jthom330/VR-Info-Booths/blob/master/VR-Info-Booths/Screenshots/Room.png)](https://youtu.be/kHp_4z3tXe8)

## Development

### Concept
Based on the assignment description, I simply wanted to created several different areas that would allow the user to see display items and listen to some kind of audio.  Using way-points that the user could pick between to visit different exhibits seemed like a perfect fit, so I decided to use this idea for my movement system.  In order to incorporate the audio element, I wanted to add a panel or UI element at each exhibit that the user could activate.  During my initial design phase, I did not have a particular level layout or theme in mind.  At this point I just knew I wanted an open area with a different space for each exhibit.

Original Level Design Sketch: 

![Sketch](https://github.com/jthom330/VR-Info-Booths/blob/master/VR-Info-Booths/Screenshots/sketch.png "Level Sketch")

### Audience
I found this assignment very difficult to create a persona or audience to design for, due to how basic and restrictive I felt the content needed to be.  Ultimately, I landed on an audience that have little to no real-world knowledge of VR and are not very tech-savvy.  I selected this audience because the format of having small virtual displays to show examples and explain newer technologies could be useful to those who do not keep up with tech trends like VR.

#### Persona
**Age:** 60

**Occupation:** High-School English Teacher

**Name:** Richard Lake

**Quote:** “I wish I understood some of these gadgets better.”

**Summary:** Richard is a caring teacher, but doesn't pay any mind to his student's modern hobbies like mobile games or anything tech related. He doesn't tend to use computers for anything more than checking emails and doing what is required for his job.
VR Experience: None

### User Testing 
For this project I did two rounds of testing.  The first round was after getting the displays setup, but without any audio.  The second round was as I was finishing up, to make sure everything flowed together well.  

#### First Round Results 
##### User observations
* Needs some ambiance or background music
* There are some strange shadows in the scene

##### Changes Made
* Added some background music that seems appropriate to the setting
* Scene was not baking properly, due to an asset import issue.  Recreated the light map to fix it.

#### Second Round Results 
##### User observations
* Background music drowns out the narration

##### Changes Made
* Decreased volume of the music and increased volume of the narration

## Conclusion

Finished Game Screenshots:

![Screenshot](https://github.com/jthom330/VR-Info-Booths/blob/master/VR-Info-Booths/Screenshots/Social.png "Screenshot")
![Screenshot](https://github.com/jthom330/VR-Info-Booths/blob/master/VR-Info-Booths/Screenshots/Creation.png "Screenshot")

### Level Design
When starting this project, I had just two broad ideas for what I wanted the level to be like.  First, I wanted the playable area to be a wide open space, without separate rooms. Second, I wanted to have pictures and multiple 3D models and props for each display.  Since I didn't have a specific theme for the level in mind, I searched around the Unity assets store for a few examples that I liked.  I decided on the museum level because I thought it would work the best with the pictures and models I wanted to display.  Unfortunately, I was not able to find relevant 3D props for my displays and creating them would have taking much too long.  Since getting models didn't seem practical, I decided to find extra images and put them on Unity's primitive 3D shapes instead.  While I would have liked to have had better props for some of the displays, I feel like it turned out pretty well.

### Scripting
For this assignment, I wrote my own C# scripts to cover the user's basic interactions.  I used iTween to move the player between way-points, as I feel that fast movement worked better than instantly teleporting the player.  I tied UI button presses to playing my recorded audio clips, and stopped all audio clips if player left the area.  Finally, I added some simple hover effects to the way-points to draw attention to them and display the name of the exhibit.  I really love scripting and would have loved to have done more, but I couldn't think of any other meaningful things I could have created scripts for.  

### UI
The UI for this project was pretty simple.  I created a panel with some basic instructions for the player when they start and panels for each display area that the player can click to start the audio narration.  The only area I struggled with was creating UI text for each exhibit's title.  I started by putting floating text next to each display, but it felt very cluttered.  I then tried putting the text flat against the floor in front of each display.  This worked well, but was difficult to read for areas that were further away.  Finally, I settled on showing the display title when the user's hovers over the way-point.  I did not feel like there was much information to display, so the UI was very minimal as a result.    

### Audio
Probably what I deliberated the most on was what to do for the audio component of this assignment.  As much as I tried, I could not think of any sound effects or available clips that would bring any value or tie the display items together in a meaningful way.  As a result, I decided to record my own narrations and add them to the displays.  I don't have any good recording equipment, nor am I much of a voice actor, but I feel that the results work well enough.  

### Closing 
This project was challenging to me in non-technical ways.  I really struggled to make this project interesting to both myself and the intended audience.  The original assignment struck me as very dull and dry.  In order to combat this I picked topics I was personally invested in and brainstormed some ideas that would make the scene pop.  While I would have liked to have had more props and items to make the displays with, I feel like it turned out well.  

Now that this application is completed I will be hopefully be starting the last term of Udacity's VR program.

You can check out some of my other projects at https://www.wileythompson.me/


