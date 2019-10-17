This code was written using .NET core on CentOS7.

# Getting Started

Install .NET core from [https://www.microsoft.com/net/core](https://www.microsoft.com/net/core).

```bash
$ ./bin/setup
$ ./bin/spec
```

The expected output is included below for comparison.

```bash
λ ./bin/spec 
Build started, please wait...
Build completed.

Test run for
/home/mokha/development/banking/spec/bin/Debug/netcoreapp1.1/spec.dll(.NETCoreApp,Version=v1.1)
Microsoft (R) Test Execution Command Line Tool Version 15.0.0.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
[xUnit.net 00:00:00.8989171]   Discovering: spec
[xUnit.net 00:00:01.0999284]   Discovered:  spec
[xUnit.net 00:00:01.1805071]   Starting:    spec
[xUnit.net 00:00:01.5277478]   Finished:    spec

Total tests: 19. Passed: 19. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 2.5721 Seconds
```

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
