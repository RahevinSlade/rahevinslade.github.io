# Rahevin's HW8 Blog

1) Has scripts to create, populate and delete the database

Created an Up and Down Sql script along with the .mdf file to store everything in. Also created a ER Diagram on paper before creating and UP script.

![Screenshot of Up Page](ERDiagram.PNG)

![Screenshot of Up Page](Up.PNG)

![Screenshot of Down Page](Down.PNG)

![Screenshot of Populate Page](Poplute.PNG)

2) Tables have appropriate names, genres,relations/constraints and classifications. 
Artists has an ID that is a foriegn key to Artworks, and Artworks has a foriegn key in Classification, and Genres has a foriegn key in Classifications. 

![Screenshot of Tables Page](Tables.PNG)

3) Main page has menu, with lists pages showing all entities

Menu page displays links to the next pages which will display all entites within the following table and details.

![Screenshot of Tables Page](Menu.PNG)

![Screenshot of Tables Page](Menu.PNG)

4) Has a working CRUD functionality for artists.

I used auto gen code and then edited to work for my written code. To view more watch the Demo video after step 6.

![Screenshot of Tables Page](CRUDmenu.PNG)

5) Has a genres buttons, shows works and artists, sorted correctly

This is what uses Ajax for the menu buttons, inside the Home View Index. 
```
    @foreach (var item in Model.ToList())
    {
        <button class="btn btn-primary" onclick="Ajax('@item.GenreID');">@item.GenreName</button>
    }
```

![Screenshot of Tables Page](MenuSur.PNG)

6) Uses AJAX

Ajax is saved inside of scripts and when including in a file we do the following. Saved as gajax.js

```
@section Javascript
{
    <script type="text/javascript" src="@Url.Content("/Scripts/gajax.js")"></script>
}
```

![Screenshot of Tables Page](AJAX.PNG)

## Demo Video

Find it in my GitHub [here](https://github.com/RahevinSlade/rahevinslade.github.io/tree/master/HW8/HW8/HW8)

Press play below, it will look like nothing is happening for about 5 seconds, then things will begin to happen.

<video width="1000" height="666" controls="controls">
  <source src="Demo.mp4" type="video/mp4" />
</video>

Personal notes for later, small steps to get started and move things quicker next time.

Step 1)

Ensure you have entity frameworks installed (if so proceed to next step).

Once your project opens, click Tools, click NuGet Package Manager, click Manage NuGet Package solution, then Browse and search "entity" select EntityFramework, click your project and install, click ok, I Accept.

![Screenshot of Step 1](1.PNG)

![Screenshot of Step 2](2.PNG)

Step 2)
Include your UP and Down script inside the App_Data.
-create as a new file outside of the project then add save it in the App-Data folder, then right click App_data and add existing item.

Include in you App_Data, add, new item, select SQL Server Database add should be a .mdf file.

Then go to Server Explore find your .mdf file and refresh, now you should be able to connect your SQL scripts.

![Screenshot of Step 3](3.PNG)

Run UP script

Step 3)

right click Models, add new item, under Visual C#, select Data, the click ADO.NET Entity Data Model. Name it "NameContext". then choose Code First from Database click "next" select your .mdf file, click next, then select your tables and dbo. click finish

![Screenshot of Step 4](4.PNG)

![Screenshot of Step 5](5.PNG)

Step 4) 

Adding CRUD for Artist

Be sure to reload the solution, then right click Controllers, add, new scaffolded item, then select MVC 5 Controller with views, using Entity Framework. 

![Screenshot of Step 6](6.PNG)

![Screenshot of Step 7](7.PNG)

repeat this process for each view or controller you'll need

![Screenshot of Step 8](8.PNG)

Step 5)

Now you just need to fix your layout page so you can cruise your new tabs.

![Screenshot of Step 9](9.PNG)

Step 6) 

Now to display ajax and get genres to display on home page using razor.

This is what we will include inside the Views where we use our Ajax.

![Screenshot of Step 10](10.PNG)

Here is how we will use razor and spit out all the Genres as buttons

![Screenshot of Step 11](11.PNG)

Place the Ajax file "gajax" inside the scripts folders as a .js file.
Click Add, New item, then under Web, select JavaScript File.

![Screenshot of Step 12](12.PNG)

![Screenshot of Ajax](AJAX.PNG)

You'll also need to alter the HomeController and include Models such as the followings.

![Screenshot of Step 13](13.PNG)

Now this should work.

