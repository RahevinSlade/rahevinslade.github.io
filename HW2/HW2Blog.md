# Rahevin's HW2 Blog 

Below are the requirments for homework 2

1) Use Git feature branch
```
git branch
git checkout -b feature
```


2) Merge feature branch back to Master
```
git add .
git commit -m "Added feature branch, with a reset button"
git push
git checkout master
git merge feature
```


3) have a wireframe of initial design

![Click Me](./wireframe.pdf) to view the hand drawn picture of the wireframe I have made, you'll notice small differences between the drawn version and final one.


4) Uses Javascript
``` 
<script>
 // Starting attempt number
            var start = 7;
// Random number chosen to compare with users number, chooses a number 1 - 100
            var Rando = Math.floor((Math.random() * 100) + 1);
 // This function is called with the reset button, which then reloads the page, thus reseting the game
            function Reset(){
                location.reload();
            }
//theres some more code inbetween
    </script>

```


5) Uses Javascript to access the DOM
```
            if (Rando == guess) {
// if the user number is equal to the random number, tells the user they did it!
                    document.getElementById("result").innerHTML = "Success!";
                    document.getElementById("myBB").disabled = true;
                    document.getElementById("Atts").style.color = "#33f35a";
                    document.getElementById("sneeks").innerHTML = "The Answer was " + Rando;
                }
```                


6) Takes in User input, doesn't fail if incorrect
```
<!-- This text box only allows numbers within, which is used for the game, also allows user to use the enter button, restricted to 1-100, if a user enters a high number it will auto assume it is higher the random number-->
            <input type="number" id="myEnt" min="1" max="100" onkeypress="keyCode(event)">
    <!-- This button calls attempts, which then compares the users input with the generated number -->
            <button id="myBB" onclick="Attempts()"> Enter </button>
```


7) Button responds to Javascript
```
<!-- This is where we will display attempts left to the user, along with the result tag -->
        <div id="actions">
            <p id="Atts"> 7 </p>

// This function is where its all at, This is where we compare the user number with the random number, if the user did not input a number, the default is 0
// This is also where we decrease the number of attempts left once the user has entered their guess
// This is also were we change the color of attempts left to help out the user with hints, higher number than random is red, lower number thand random is blue. equal to is green
// This function also disables the enter button after all attempts have been used, after all attemps are used a message will be display informing the user the random number
            function Attempts() {
                var att = 1;
                start = start - att;              
```


8) Uses Jquery to modify and add to DOM to display results
```
//start = 7, after each attempt it is decreased by 1 this is the 
//following code the displays the remains attempts
document.getElementById("Atts").innerHTML = start;
```