# Damovisa.WhoNeedsTests

A replacement for `Assert` that lets you pass all your tests and maintain code coverage.

YES, THIS IS A JOKE.

If you use this in a real project, that's totally on you.

## Step 1 - Adding to your project

Well, again, _don't_ use it.

Still here? Oh, ok then. You have two options to include it in your project:

### Copy-paste

There's only one class, so copy and paste that into your own file. Call it what you want.

### Import the Nuget package (not working yet)

Install the Damovisa.WhoNeedsTests Nuget package. Either through the UI or from the Nuget Package Manager:

    Install-Package Damovisa.WhoNeedsTests

## "Fixing" your tests

Oh wow, you're really planning on using this, huh? Well ok...

To "fix" your tests, just find all instances of the word `Assert`, and replace them with `Asserṭ`.

This new `Asserṭ` will never fail a test, and at first glance it looks the same as `Assert`. Your tests will all run, but your assertions will no longer fail. Yeah, you're welcome.