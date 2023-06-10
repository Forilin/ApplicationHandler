# ApplicationHandler

How it works:

Basically, it is a way to manage your applications (C#) easily and simply using a class. You create a class for each application that you wish to use.



To create an integer-type application, such as a counter or a point system of some sort, use this code:

NumericApplicationHandler handler = new ApplicationHandler.NumericApplicationHandler(application_name)


To create a string-type application, use this code:

StringApplicationHandler handler = new ApplicationHandler.StringApplicationHandler (application_name)

- What can you do with it?

With your NumericApplicationHandler you can do the following things:

- Set its value with a string ( NumericApplicationHandler.Set )
- Set its value with an int ( NumericApplicationHandler.SetWithInt )
- Get its value as a string ( NumericApplicationHandler.Get )
- Get its value as an int ( NumericApplicationHandler.GetAsInt )
- Add 1 to its value ( NumericApplicationHandler.AddOne )
- Remove 1 from its value ( NumericApplicationHandler.RemoveOne )
- Remove the last char from its value ( NumericApplicationHandler.RemoveLastChar )
- Remove the first char from its value ( NumericApplicationHandler.RemoveFirstChar )
- Add a numeric value to its value ( NumericApplicationHandler.AddWithInt )
- Remove a numeric value from its value ( NumericApplicationHandler.RemoveWithInt )

Examples to using these funcs (the value of the application is "123" [type string] before each one of these functions):


NumericApplicationHandler.Set("10"):
// the application's value now became "10"

NumericApplicationHandler.SetWithInt(15):
// the application's value now became "15", even tho we put an integer and not a string in the param

NumericApplicationHandler.Get():
// returns "123" (string)

NumericApplicationHandler.GetAsInt():
// returns 123 (int)

NumericApplicationHandler.AddOne():
// the application's value is now set to "124"

NumericApplicationHandler.RemoveOne():
// the application's value is now set to "122"

NumericApplicationHandler.RemoveLastChar():
// the application's value is now set to "12"

NumericApplicationHandler.RemoveFirstChar():
// the application's value is now set to "23"

NumericApplicationHandler.AddWithInt(7):
// the application's value is now set to "130"

NumericApplicationHandler.RemoveWithInt(2):
// the application's value is now set to "121"



With your StringApplicationHandler:

- Get the application's value ( StringApplicationHandler.Get )
- Set the application's value ( StringApplicationHandler.Set )
- Add a char to the str's value ( StringApplicationHandler.AddChar )
- Remove the char at a specific index ( StringApplicationHandler.RemoveAtIndex )
- Remoeve the last char ( StringApplicationHandler.RemoveLastChar )
- Remove the first char ( StringApplicationHandler.RemoveFirstChar )

Examples of using them (the application's value is set to "Hello, world!" in all funcs):

StringApplicationHandler.Get():
// returns "Hello, World!"

StringApplicationHandler.Set("Report"):
// sets the application's value to be 'Report'

StringApplicationHandler.AddChar("Z"):
// sets the application's value to be 'Hello, World!Z'

StringApplicationHandler.RemoveAtIndex(2):
// sets the application's value to be 'Helo, World!'

StringApplicationHandler.RemoveLastChar():
// sets the application's value to be 'Hello, World'

StringApplicationHandler.RemoveFirstChar():
// sets the application's value to be 'ello, World!'
