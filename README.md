# FinalExamINFR3310

Using Parisa Base Provided

Object Pooling Explanation
=================================
Intention: To increase number of enemies in scene
Implementation: I would have attempted to create multiple instances of enemies and platforms by utilizing object pooling to pre-load each enemy before the scene loads, allowing for better performance/less lag. Object Pooling, as stated before, allows for better performance; however, it also allows for a large amounts of objects to be instated and placed in real time. In this specific case, object pooling would have been used to spawn more enemies and more platforms when the player kills all the currently alive enemies.

Command Design Pattern Explanation
=================================
Intention: To undo the previously collected "coins"
Implementation: Firstly, as there were no coins placed in this starter scene, a coin object would have had to be placed multiple times in-order to begin the implementation of the command design pattern. To implement the design pattern, the amount of coins picked up would have to be kept track of through a counter, as well as their placements. Once 7 have been aqquired, a request to instaiate the coins that were picked up could be requested, and by using object pooling, placed back in the original spots, allowing players to pick them up again for more points. A UI element explaining this mechanic could be added to inform players.

Game Management System:Speed Manager
=================================


Intention: When players kill an enemy, their jump height and movement speed are increased.
Implementation: When a player kills the enemy, a counter is increased and boolean is set to true; which is sent to a "Speed Controller" script, that keeps track of how many enemies are killed, and based on that number and if an enemy has been killed, will send a value to the player controller increasing both walk speed and jump height by 2.5f. This helps to speed up the player's movement, and provides a reward for killing the enemies. I would have added a UI element to show how many enemies the player has killed; however, I was unfortuntely unable to implement this, and opted to go with a console output as a quick alternative.
