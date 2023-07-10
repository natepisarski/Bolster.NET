# Bolster.NET
Make your C# code stronger with functional practices, without needing to use F#!

[Tony Hoare](https://en.wikipedia.org/wiki/Tony_Hoare), the inventor of null, called it the "billion dollar mistake". This package was created to create good non-nullable types in userland before they were a feature of C# itself.

Now that C# supports them natively, the primary benefit of this package is the `Curry` extension method. It allows you to do partial application in native C#.


## What exactly is it?
`.Curry` is an extension method that allows you to partially apply a function. For instance:

**Add 2 numbers together**
```C#
Func<int, int, int> add = (int1, int2) => int1 + int2;
listOfNumbers.Select(add(5)); // Adds 5 to every element of an IEnumerable
```

Partial application is a powerful design pattern once you understand it. It allows you to perform [dependency injection](https://en.wikipedia.org/wiki/Dependency_injection), [memoization](https://en.wikipedia.org/wiki/Memoization), [mocking](https://en.wikipedia.org/wiki/Mock_object), and more. In most cases, it just reduces the length and [cognitive load](https://en.wikipedia.org/wiki/Cognitive_load) of your code.


