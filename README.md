This code was written using .NET core on CentOS7.

# Getting Started

Install .NET core from [https://www.microsoft.com/net/core](https://www.microsoft.com/net/core).

  $ ./bin/setup
  $ ./bin/spec

# Review

Each of the given case described in the problem statement have been
completed in `spec/acceptance/account_spec.cs`.

# Comments

Some shortcuts were taken in order to meet the time constraints.

E.g.

* optimisitic transfers
* one way currency conversions (i.e. only convert to CAD)
* basic .net conventions ignored due to lack of relevant experience with language.
* ignored fields that seemed irrelevant. (i.e. customer info and account #)

Enjoy!
