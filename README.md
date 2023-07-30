# Hangman

## Overview
This repo is for the implementation of classic game of Hangman.
This software is created as a single player game to test player’s vocabulary bank. 

## The Game 
A player is presented with blanks, specifying the amount of letters in the chosen word. The player can then
choose a letter. If the word contains that letter, it will show up in the correct blank(s). If the word does not
contain the letter, a part of Mr. Hangman’s body will be drawn. The player keeps going; if the word is guessed
before Mr. Hangman is complete, the player wins. If Mr. Hangman is complete before the whole word is
guessed, the player lost.

## Game Process and Rules
<p> • Message box displays: “Pick a word to start”
<br>• Player picks a word, and the software randomly chooses a word and generates that amount of blanks.
The letter buttons are enabled.
<br>• The player chooses a letter – the computer checks if the word contains it. If it does, the computer
inserts it, and message box displays “Got it!”.  If it doesn’t, Mr. Hangman gets another body part and
message box displays “Oh, no!”
<br>• The game ends either when Mr. Hangman is complete or when the word is complete. Message box
displays whether the player won or lost.

## UI Elements

![Moqup](https://github.com/nissirosenberg/Hangman/assets/116742844/453c6b4b-0eb5-4eae-a5df-ee14fb42c331)
