# Anything Trigger

`AnythingTrigger` is a C# script for Unity that defines an event trigger for colliders that can be configured in the editor inspector without code to trigger any type of action. The script provides several customizable options, including the tag that the collider must have to trigger the event, whether the game object should be destroyed when the trigger activates, and how long to wait before destroying the game object. The script also provides an option to only trigger the event once.

## Installation

To use `AnythingTrigger` in your Unity project, simply copy the `AnythingTrigger.cs` script into your project's `Assets` folder.

## Usage

To use `AnythingTrigger`, attach the script to a game object that has a collider attached. The script provides several options that can be customized in the Unity Inspector:

- **Seeking Tag**: The tag that the collider must have to trigger the event.
- **Destroy On Trigger**: Whether the game object should be destroyed when the trigger activates.
- **Time To Destroy**: How long to wait before destroying the game object.
- **Only Trigger Once**: Whether the trigger should only activate once.
- **On Trigger Enter Event**: The UnityEvent that gets triggered when the collider with the seeking tag enters the area.
- **On Trigger Exit Event**: The UnityEvent that gets triggered when the collider with the seeking tag exits the area.
- **On Trigger Stay Event**: The UnityEvent that gets triggered when the collider with the seeking tag stays within the area.

When the trigger is activated, the corresponding function (`OnTriggerEnter`, `OnTriggerExit`, or `OnTriggerStay`) is called. If `Only Trigger Once` is true and the trigger has already activated, the function exits without doing anything. If the collider has the correct tag, the respective UnityEvent is triggered, and the `Destroy On Trigger` and `Time To Destroy` options are taken into consideration. Finally, if `Only Trigger Once` is true, the trigger is set to only activate once.

## Example

Here's an example of how to use `AnythingTrigger`:

1. Create a new game object in your Unity scene and add a collider to it.
2. Attach the `AnythingTrigger` script to the game object.
3. In the Unity Inspector, set the `Seeking Tag` to the tag that you want to trigger the event.
4. (Optional) Set the `Time To Destroy` if you want the game object to be destroyed after the trigger activates.
5. (Optional) Check the `Only Trigger Once` box if you only want the trigger to activate once.
6. Add any functions that you want to trigger to the `On Trigger Enter Event`, `On Trigger Exit Event`, and `On Trigger Stay Event` in the Unity Inspector.
7. Save your scene and run your game.

## License

`AnythingTrigger` is released under the MIT license. See the [LICENSE](LICENSE) file for more details.

## Credits

`AnythingTrigger` was created by Robert Rumney. Feel free to contribute to this project by submitting pull requests or issues.
