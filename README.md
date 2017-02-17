# BDD
## A project by Melvin Gruschow, for Epicodus
### Created and copywriten February 2nd, 2017

#### Description:
A web browser viewed, c# based application that lets the user enter in a word/phrase and then enter another single word, and counts how many times the second word is found in the first word/phrase.

#### Instructions:
This application requires .NET framework, a web browser, and powershell
Clone this repository, and use the command 'dnu restore' in the root directory of this repository.  Then use the command 'dnx kestrel' to start the application running, and travel with your browser to localhost:5004.  

### SPEC:

* - input string
  - output said string
  - if the string the user inputs matches the one the object contains, we can begin the work

* - input searchitemstring
  - output the same string
  - if the string the object has is the same as the searchitemstring the user inputs, we can accurately search our previous string

* - input 2 matching strings
  - output they match
  - this is the first test of the code, matching 2 same strings

* - input 2 nonmatching strings
  - output they dont matching
  - checking for consistency so we dont get errors down the line

* - input a sentence string and a word string, the sentence containing said word
  - output there is 1 match
  - testing our code to see if we can count matching strings within a sentence

* - input a sentence string and word string, with multiple occurrences of said word in said string
  - output # of matches
  - final test of our code, counting ever instance of matched string
