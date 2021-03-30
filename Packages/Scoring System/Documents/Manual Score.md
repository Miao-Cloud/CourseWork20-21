# Scoring System User Guide

---

This document explains the behaviours contained in this package and describes how to use them to create a simple scoring system. One that involves collecting and depositing.

---

# Behaviors

- Collect
- Deposit
- ScoringSystem

---

# Collect

This scrip will add 1 or how ever many points you wish to the score counter. It will also destroy the object on collision.

This script should be placed on the object you wish to collect. Make sure the collider is set to is triggered.

---

# Deposit

This script will subtract 1 or how ever many points you wish from the score counter.

This script should be placed on the object recieving the objects you have collected. Make sure the collider is set to is triggered.

This script is only necessary if you wish to have a collection deposit mechanism.

---

# ScoringSystem

This script will update the on screen UI which holds your score.

This script should be placed on an empty object, out of sight and working smoothly.
