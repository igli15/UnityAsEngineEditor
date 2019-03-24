# UnityAsEngineEditor

This Unity project is used as a level editor for the custom engine [MGE](https://github.com/igli15/Project-Third-Person).
It was developed to help Designers and Artists to edit values and scenes based on their liking and not having to recompile
everytime a small value changed.

The parser will export a xml file with all the data needed. The xml file has to be placed in the engine scene folder and then 
the engine will automatically convert the data as needed.

## Features
Supports all engine components (Camera/Light/Collider/Rigidbody etc).

Unity scene positions and rotations are parsed properly as viewd in the scene.

Left Handed to Right Handed conversion is done by the parser.

Supports custom components (Have to manually be parsed from the engine).
