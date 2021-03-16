# Elevator User Guide

---

This document explains the behaviours contained in this package and describes how to use them to create an elevator.

---

# Behaviors

- Elevator

---

# Elevator

This script will make an elevator. It will be activated by the player standing on it and pressing the assigned keys to go up and down. These keys can be changed through the script.

You will need to add two floors, an elevator, a top and bottom empty asset and a canvas.

The bottom empty asset will be where the elevator starts, the top will be where the elevator ends.

For the canvas, add an image, a square will do, place it in the bottom right hand corner and name this elevator panel. Create a child text object and write in the keys to go up and down.

Now that all this set up is done, once the script is placed on the elevator object, add another box collider to it, put it above the object and set it to is triggered. Now to fill in the slots on the script.

ElevatorPanel = Your elevator pannel

Top = Top transform

Bottom = Bottom transform

Set smooth to 3.
