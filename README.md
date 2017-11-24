# ECS model experiment
An experiment project playing with Unity's Entity Component System model.

## Features
- Human and Alien team
- 1 commander, 4 soldiers and 1 medic in each team
- Commander and soldiers walk in circle and shoot random enemy team member
- Commander moves slower and is bigger but has a shield that blocks damage
- Medic strafes sideways behind other team and heals closest team member
- Hud-text for remaining team members
- Win text for each team

## TODO
- Hud view for game over

## DONE
- Health bars
- Movement pattern for soldier
- Movement pattern for medic
- Weapon shooting mechanics
- Weapon targeting mechanics
- Hit mechanics
- Life & death mechanics
- Shield mechanics
- Healing mechanics
- Attachable weapon object
- Both teams has full team composition
- Hud view for remaining team members
- Observer pattern for hud
- Singleton pattern for hud
- GameManager, that keeps count of teams
- HudManager gets count from GameManager

## TOFIX
- Weapon shoots occationally in the wrong direction.

## FIXED
- Circular movement only works at position (0,0)
- Teamcount doesn't work with observer pattern implemented.