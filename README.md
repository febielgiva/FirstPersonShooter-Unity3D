# FirstPersonShooter-Unity3D


# H1 Magical Mystic Shooter

Download
------------------
**Full project link**
https://drive.google.com/open?id=0B0daU37erFBqOHVSdGpGbzNtYlk


Game Description
------------------

**Introduction**
	My environment is an old ancient temple in a village where the player is out to unleash the hidden secrets, treasures of a powerful king ruled 50 years ago. The village believes that the king’s army is immoral and trying to protect the treasure and waiting for the right time to raise the king back from death. The player have to kill the king’s army with the magical powers and should reach the destination to destroy the king’s tomb in order to win the game.

Game Overview
--------------

|Genre:|	FPS|
|:-------------:| -----:|
|Player:	|Single|
|Game Elements:	|shooting, collecting hearts, reaching the target , killing the enemy , jumping, running, walking , changing powers , |changing player and enemy settings, teleporting |
|Game Content:	|Drama| 
|Theme:	|Fantasy|
|Style:	|Manga,|
|Game Sequence:	|Planning to implement(Linear- Storylines)|
|Player Immersion:	|Tactical, Strategy, Physical,Mental|
|Technical From:	|Basically this is 3D graphics with fully animations with contorls|
|View:	|First person as well as third person view available|
|SW Platform:	|C#|
|HW Platform:	|PC|
|Audience	|High school students,  adults |


Game Features
------------------

**1)	implementation features of your game **

GUI 

On the Main Screen 
**Player’s Health- **
*	I used a Slider to display the Player’s health. 
*	It will be in the top middle of the screen always.
*	Initially the Player has full health 
*	The Player’s health will decrease when the enemy hits the player (decrease by 1)
*	The Player’s health will increase when the play grabs the heart or star which is available in the two rooms. The heart or star once grabbed, it will disappear and appears after some time again in the same location. (increase by 5)

**Enemy Hit count-**
*	I used a text to display the Score of the Player.
*	It will be displayed at the top left corner of the screen on top of the cup image.
*	The count is increased if the player hits the enemy and it reacts to the hit ie when it dies.

**Room ID**
*	I used a text box to display the Room ID.
*	The display is present in the bottom left corner of the screen
*	On teleporting to the room ID changes

**Setting **
*	I used a button for opening the settings menu
*	It is located at the top right corner of the scene
*	On clicking on the settings button - a pop up screen is displayed
It has the following
1.	Player’s Name -text box to get the player’s name.
2.	Slider to Change the Player’s Speed 
    On moving the handle of the slider the speed of the player is increased or decreased accordingly 
3.	Slider to Change the Enemy’s Speed
On moving the handle of the slider the speed of the enemy is increased or decreased accordingly
4.	Close 
Click the close button to exit the pop up
       Audio Controls
	Clicking on the button mute or unmute the audio
	
**Inventory Management**
On collecting the key , coins and health the count , its icon is displayed in top of the screen alone with  the button functionalities to use it .


**On reaching the teleport hot spot**
Only if the mission of that level is successfully a pop up is displayed automatically that has a Question textbox that displays randomly picked question from my question bank (I created class for having all the questions, answers, options). 

If the mission is not completed then a pop stating the mission target is displayed.

Drop Down 
*	The options are displayed in the dropDown to select your answer
Submit Button
*	To submit the answer, click on the submit button
*	If the answer is right, then you will be teleported accordingly 
*	If the answer is wrong a popup is display with the message “Oops wrong answer”. In the Pop Up on clicking on the Continue button you can continue playing
Quit
*	To close the Question pop up click on the Quit button
Keystrokes GUI
	ESC – A pop up to Save,Resume,Quit the game 
	M – To know the current mission 
        F1 – Help Menu
        S   - Save
        R  - Reload
        Q – Quit pop up menu displays.


**All designs for GUI are designed by me in Photoshop using the images and brushes available in the internet.**

**PLAYER **
Player has two camera views -First person view and Third person view. Third person view is used to collect the health packs and first person view is used for shooting. Player has the animation for jumping, walking, idle, shooting


**ENEMY**
Enemy has the shooting, running, idle, dyeing animation. I have used NAV MESH  for finding the player character. 


**2)“how to play” your game.**
	WSAD – keys for up , down,left ,right movement
	Mouse left click – To shoot
	Mouse Right Click – To change the weapon
	V -to toggle the camera view
	Space - Jump
	ESC – A pop up to Save,Resume,Quit the game 
        M – To know the current mission 
        F1 – Help Menu
        S   - Save
        R  - Reload
        Q – Quit pop up menu displays.


**Mission Management**
Level 1 – The player should kill at least 3 enemies and collect at least 10 coins to go to level 2
Level 2 – The player should find the king and kill him in order to unleash a treasure to complete the mission


If the user health is 0 then that level starts from the first automatically only the inventory items are preserved



Resources
------------------

*	Animation character and animations from the below link
https://www.mixamo.com
*	Models from the below link
http://tf3dm.com/
*	Skybox
http://www.custommapmakers.org/
