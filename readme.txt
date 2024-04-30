User Controls:
- Use WASD or Arrow keys for player movement.
- Holding shift key with movement keys to sprint
- Press space key to jump
- press esc button to pause or play the simulation
- After equipping the spray pump, hold left mouse button to start spraying the pesticide.
- Release left mouse button to stop spraying.

Features:
- 5 dimensional player movement.
- Animations based on directional movement (using blend tree in animator controller).
- Use of special UI elements to display the item description when selected.
- Use of checklist for the items in the PPE kit when picked up. 
- The player cannot access the sprayer pump nor enter the field until the user puts on the PPE kit.

A step by step process for the simulation:
1) At first the user will be in the main scene where there will be two options: Start and Quit
   Start will take the user to the simulation and using Quit button the user can exit the simulation.
2) After entering the simulation there's a table on the player's left. Navigate to the table using the movement keys.
3) On the table the user will see various PPE kit items. Select them one by one where each item has a description when selected.
4) Now the user should move towards the field where a spray pump is placed. The user will only be able to enter the field once picking up the pump.
5) After picking the pump, the user can enter the field and start spraying.
6) The user can exit the simulation at any given time using escape and quit button.