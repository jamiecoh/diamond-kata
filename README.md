# diamond-kata

One of many possible solutions to the [Diamond Kata](https://github.com/davidwhitney/CodeDojos/tree/master/Diamond%20Kata) exercise. 

I decided to start this project using a TDD approach as it was well suited to doing so, which can be seen in the initial check in to this repository.
Testing uses [FluentAssertions](https://fluentassertions.com/) as its a great library for quick/efficient development of unit tests.

The `Diamond` class is static as it holds no state, and exposes its alphabet to aid with testing & validation.

The console application exists only to demonstrate the functionality by printing the result to the console, it accepts one argument which must be an uppercase character in the range A-Z.