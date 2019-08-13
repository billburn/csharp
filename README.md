# csharp

__Data Types__
* string => string name = "Hello World!";
* int => int myAge = 25;
* double => double weight =  25.23;
* char => 'a', 'R', or '&';
* bool => bool answer = True;

__Writing Data to Console__

*With WriteLine, this will add a linebreak after the WriteLine*
```
Console.WriteLine("some text");
```

*With the Write, this will NOT put a linebreak after the Write*
```
Console.Write("some text")
```

__Start a new project in Visual Studio Code__
* dotnet new console

__Compile to executable in Visual Studio Code__
* dotnet publish -c Release -r win10-x64
