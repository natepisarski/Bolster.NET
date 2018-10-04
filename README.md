# Bolster.NET
Bolster lives up to its name. It makes your C# code stronger in the sense that it is far less prone to errors. 

[Tony Hoare](https://en.wikipedia.org/wiki/Tony_Hoare), the inventor of NULL, has called it his "Billion Dollar Mistake". Since his mistake, there has been decades of research Programming Language Theory. The consensus is that modern languages are sorely missing out on benefits that more academic languages, like Haskell or Idris, have been implementing.

These benefits largely come from these language's type systems. They allow you to represent Higher-Kinded types, dependant types, and all these cool theoretical academic things. But... how does this relate to Bolster at all?

## What exactly is it?
Bolster is a library that makes everyday use of C# more reminiscent of languages with safer type systems. `Result` lets you know whether something completely correctly. **No EXCEPTIONS, ever**. `Maybe` lets you return a missing value. **No NULL's, ever.** `Curry` allows you to partially apply functions, so that if you have:

`Func<int, int, int> add = (int1, int2, int3) => int1 + int2 + int3`

then you can say 

`var curried = add.Curry(4)`

... and then `curried(5)` is 9! Partial application is at the heart of these functional languages (including F#), and has numerous benefits when performing actions on sets of data, or trying to implement dependency injection. Simply partially apply a connection string or a cloud service, and voila! You're now passing around something without any dependencies at all.


