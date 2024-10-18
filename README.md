Purpose:

This script is designed to manage transitions between different rooms or scenes in a Unity game. It allows the player to navigate through a series of predetermined room positions using a smooth camera movement animation.

Usage:

Attach to a GameObject: Attach the RoomTransition script to a GameObject in your Unity scene.
Set up Room Positions: Assign Transform components to the roomPositions array, representing the positions of each room.
Configure Camera: Set the mainCamera variable to reference your main camera.
Assign Buttons: Assign the "Next" and "Previous" buttons to the nextButton and previousButton variables.
Functionality:

Room Movement: The script allows the player to move between rooms using the "Next" and "Previous" buttons.
Camera Transitions: The camera smoothly transitions between room positions using a coroutine.
Button Visibility: The visibility of the "Next" and "Previous" buttons is updated based on the current room index.
Customization:

Room Positions: You can add more or fewer rooms by modifying the roomPositions array.
Camera Movement: Adjust the duration parameter in the MoveCamera() coroutine to control the speed of the camera transition.
Button Appearance: Customize the appearance of the "Next" and "Previous" buttons to match your game's style.
Additional Features: Consider adding features like sound effects, animations, or interactive elements to enhance the room transition experience.