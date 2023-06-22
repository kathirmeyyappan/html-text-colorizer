# html-text-colorizer
This is a simple Microsoft GUI tool which colorizes text in custom linear gradient, outputting copy-pastable HTML code for use. I created it to learn .NET and get familiar with C#.

<p align="center">
  <img src="https://i.imgur.com/iwJ9lu6.png" alt="color preview"></img><img src="https://i.imgur.com/6i1N6I8.png" alt="color preview"></img>
</p>

Essentially, the inputted text is run through one of 4 algorithms, which will colorize it in a certain manner, outputting usable HTML code which corresponds to the preview (shown at the very bottom). Below is a  use case.

## Use
When the program is opened, you are greeted with the window below. Text is entered into the input, and then one of 4 modes is selected. Here, custom shift (a linear RGB interpolation algorithm) is selected below.
<p align="center">
  <img src="https://i.imgur.com/fLsGUsz.png" alt="color preview"></img>
</p>
Next, we slect out colors. Up to 6 spots are available When slecting a color, a color picker will show up, upon which the user picks the respective color. We also can optionally bold or italicize the output.
<p align="center">
  <img src="https://i.imgur.com/QHHcdrL.png" alt="color preview"></img>
</p>
Finally, we hit 'GET HTML' and the HTML code output and its respective preview are shown in the two boxes below. The HTML code can now be copied and used where needed.
<p align="center">
  <img src="https://i.imgur.com/f033ufN.png" alt="color preview"></img>
</p>
