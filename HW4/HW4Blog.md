# Rahevin's HW4 Blog

Below are the requirements for homework 4!

1) creat a new empty MVC project. Include a .gitignore correctly.

For this I first created a templet and played around with it to see how it works,
this one is called HomeA, the empty MVC project that was used to fill the requirements
of the this assignment is called Form.

2) Implement a feature branch and once down merge back to the master branch.

The feature branch for this assignment is called HW4. Through our the project, you'll notice comments ranging on what I accomplished to what I'm working on.

3) Create a "Home" default landing page, that contains links in an ul, and must use Razor @html.ActionLink. 

Snippet of the home page
```
@{
    ViewBag.Title = "Index";
}

<h2>Welcome</h2>
@*Welcome home, this will be our home page*@
<p> The assignment for HW4 </p>
<ul>
```

Snippet of the use of Razor, where I put the links for the other pages
```
                <ul class="nav navbar-nav">
                    @*Here we have our links to the other pages to perform there designated tasks*@
                    <li>@Html.ActionLink("Home","Index","Home")</li>
                    <li>@Html.ActionLink("Form1", "Form1", "Home")</li>
                    <li>@Html.ActionLink("Convert1", "Convert1", "Home")</li>
                    <li>@Html.ActionLink("Loan", "Loan", "Home")</li>
                    
                </ul>
```

4) Create a new page, that contains at least two text fields and a submit button. uses GET and Request. 