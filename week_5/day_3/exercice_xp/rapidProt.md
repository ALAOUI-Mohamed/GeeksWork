##### **Part 1 — Paper Prototype**



###### **Top-Down Gameplay Diagram (flow + rules):**



\[Start] → \[Hallway] → \[Enemy Room] → \[Treasure Room] → \[Exit]

&nbsp;         ↑          ↘

&nbsp;     \[Trap] ← \[Puzzle Room]





###### **Rules Notes:**



Player moves 1–6 squares per turn (dice roll).



Enemy Room → roll dice to fight; lose health if roll < enemy attack.



Trap → roll dice to avoid damage.



Puzzle → solve to get key for Treasure Room.



Treasure Room → collect treasure to win.



###### **Core Loop (Action → Feedback → Reward → Next Action):**



Action: Move into a room



Feedback: Encounter enemy, trap, or puzzle



Reward: Gain treasure, key, or survive



Next Action: Choose next room to move into



###### **Paper System:**



Dice: 1d6 for movement and conflict resolution



Tokens: 3 health tokens, 1 key token, 1 treasure token



Cards: Enemy cards (attack value), Trap cards (damage), Puzzle cards



Board/Grid: Drawn top-down map of rooms



Arrows: Show movement paths



###### **Recorded Playtest Notes (summary):**



Played 2 times with 1 other person.



Confusing: Rules for traps were unclear at first.



Too difficult: Enemy attacks were too strong early.



Too easy: Movement was sometimes too long for small maps.



###### **Questions:**



Player’s main verb: Move / explore / fight



Win/Lose condition: Collect all treasures to win; health drops to 0 → lose



Biggest issue discovered: Enemy damage too high, traps unclear



Change made to fix it: Reduced enemy attack, clarified trap rules





##### **Part 2 — Blockout / Greyboxing**



###### **Greyboxed Level:**



Cubes = walls, capsules = enemies, spheres = treasures



Layout matches paper prototype: Start → Hallway → Enemy Room → Puzzle Room → Treasure Room → Exit



###### **Basic Systems Implemented:**



Movement: Walk, run, jump



Collision: Player collides with walls, floor, and objects



First Interaction: Pick up treasure, press puzzle trigger, trigger enemy combat



1-Minute Walkthrough:



Player moves through hallways, encounters enemy, solves puzzle, collects treasure, exits



###### **Questions:**



1-Which parts of the level layout supported gameplay well?



Wide hallways and open rooms allowed smooth movement and clear sightlines.



2-Which areas need redesign?



Small corridors were too cramped; enemy placement felt repetitive.



3-Feedback from blockout tests that changed layout:



Added a jumpable platform to make movement more dynamic



Adjusted corridor widths for better flow

