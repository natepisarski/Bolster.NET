# General Idea behind Bolster
There are certain ways to Bolster the safety of your program. Expending man-hours in code review, testing, and design is one of them. Bolster is not meant to replace the need for proper design and testing, but to leverage the tools you're already using (i.e .NET's type system) to add a layer of safety.

Bolster is split up into 4 main projects:

Bolster.Base.Theory:
	The category theoretical base of Bolster. IMonad, IEndoFunctor, IFunctor, etc. These types are the staple of strongly statically typed languages, just as they're the base of Bolster.

## Bolster.Base:
	The basic types of the Bolster library. These are used ubiquitously throughout the other parts of the library. Optional types, 'Either' types, and the CanFail attribute.

## Bolster.API:
	These are the types that will be used to build rich, type-empowered API's. These include Status types (Either<Success, Failure>, Success<T>, etc)

## Bolster.Utility:
	Other functional tidbits, such as currying, composing, flipping, lazy types, and more.

And 2 supporting projects

## Bolster.Static:
	This project can be set apart from the others. It contains static code analysis tools to inform you of the safety of your code.

## Bolster.Test:
   Unit tests for Bolster.

# License
