# Plan for conducting all of the work.

## Fileds of work (Who does what)

1. slotMech.cs (The Engine)
---------------------------
_This file acts as the core "brain" of the machine. It handles the generation of results and the timing of the reels._

*   **Reel Logic:** Defines how many reels and rows are in the grid (e.g., 3×5).
*   **RNG Integration:** Generates random indices for each reel based on the symbols available.
*   **Stop Logic:** Determines the sequence in which reels stop (sequential vs. simultaneous).
*   **Result Matrix:** A 2D array or list that represents the final state of the symbols on the screen after a spin.


2. symbVal.cs (The Data)
------------------------
_This file defines what a "symbol" is and how much it is worth. It acts as the configuration layer._

*   **Symbol Definition:** A class or struct containing properties like SymbolID, Name, and ImageReference.
*   **Paytable:** A dictionary or data structure that maps a number of matching symbols (e.g., 3, 4, or 5 in a row) to a payout multiplier.
*   **Weighting System:** Assigns "weights" to symbols to control rarity (e.g., a "Jackpot" symbol has a weight of 1, while a "Cherry" has a weight of 50).


3. bonus.cs (The Special Features)
----------------------------------
_This file manages game states that occur outside of the standard base game spins._

*   **Free Spin Controller:** Tracks the number of remaining free rounds and applies specific multipliers.
*   **Scatter Logic:** Checks if special "Scatter" symbols have landed to trigger a bonus round.
*   **Mini-Games:** If the game includes a "Pick 'em" or "Wheel" bonus, the logic for those interactions resides here.


4. window.cs (The Interface)
----------------------------
_This handles the User Interface (UI) and visual representation. In a high-level C# project (like Unity or WPF), this bridges the logic to the screen._

*   **Reel Rendering:** Visually moves the symbol images to simulate a spin.
*   **Input Handling:** Listens for "Spin," "Auto-play," and "Bet Increase/Decrease" button clicks.
*   **Display Updates:** Refreshes the text fields for Total Balance, Current Bet, and Win Amount.
*   **Animations:** Triggers "Big Win" effects or symbol flashing when a winning line is hit.


5. sound.cs (The Audio Manager)
-------------------------------
_This manages the auditory feedback loop, which is essential for player engagement._

*   **Trigger Methods:** Functions to play specific clips like PlayReelStop(), PlayWinJingle(), or PlayAmbientMusic().
*   **Audio Logic:** Handles overlapping sounds (e.g., the spin sound stopping when the win sound starts).
*   **Volume Control:** Manages master volume or muting via the UI.