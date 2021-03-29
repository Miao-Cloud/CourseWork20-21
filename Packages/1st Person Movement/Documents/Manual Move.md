# First Person Player User Guide

---

This document explains the behaviours contained in this package and describes how to use them to create a first person player. It also contains an example scene.

---

# Behaviors

- MouseLook
- PlayerMovement

---

# MouseLook

This scrips should be hooked up to your camera, it will allow the player to look around in a locked FOV. 

To use this script, one will have to attatch it to a camera which is under the characters heirarchy.

---

# PlayerMovement

This script will allow the player to move around and jump. 

To use this script, one must first create an empty object and give it a character controller as well as the player movement script. After this, add in your character model, an empty object which you will drag to the bottom of the model and rename to ground check. both of these should be in the players heirarchy.

After all that, the only thing left to do is fill out the slots in the player movement script. The controller will be your entire character, GroundCheck will be the ground check and ground mask will be a new layer called ground. Give the ground layer to any objects that will be soild of walked on.
