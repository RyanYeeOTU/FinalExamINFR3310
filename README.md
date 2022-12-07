# FinalExamINFR3310

Using Parisa Base Provided


Object Pooling Explanation

Intention: To increase number of enemies in scene
Implementation: I would have attempted to create multiple instances of enemies and platforms by utilizing object pooling to pre-load each enemy before the scene loads, allowing for better performance/less lag. Object Pooling, as stated before, allows for better performance; however, it also allows for a large amounts of objects to be instated and placed in real time. In this specific case, object pooling would have been used to spawn more enemies and more platforms when the player kills all the currently alive enemies.


Command Design Pattern Explanation
Intention:
Implementation:

Game Management System

Speed Manager

Intention: When players kill an enemy, their jump height and movement speed are increased.
Implementation: When a player kills the enemy, a counter is increased and boolean is set to true; which is sent to a "Speed Controller" script, that keeps track of how many enemies are killed, and based on that number and if an enemy has been killed, will send a value to the player controller increasing both walk speed and jump height by 2.5f. This helps to speed up the player's movement, and provides a reward for killing the enemies. 
