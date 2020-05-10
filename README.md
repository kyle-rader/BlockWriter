# Block Writer (bw)

This is a program for writing out text in block letters.

# Getting Started

## Pre-Reqs
* [Install Git](https://git-scm.com/downloads)
* [Install the Dotnet Core SDK](https://dotnet.microsoft.com/download) (_Note the SDK, not just the runtime_.)

## Run Locally
* Open a new terminal (On Windows called command prompt) and clone the repository (a.k.a _repo_) by running the follwing command:
   ```
   git clone https://github.com/kyle-rader/BlockWriter.git
   ```

* `cd` into the cloned repo by running:
   ```
   cd BlockWriter
   ```

* You can run the app using the `bw.cmd` script (Windows only) and passing in arguments and options for `bw`. For example, you can print the `.gitignore` file by running:
   ```
   bw --file .gitignore
   ```
   This script will build and run the program with the given args. Building every time is slow and useful for development and rapid iteration.

* For a faster _release_ version we can publish the app creating a _distributal_ version by running:
   ```
   publish
   ```
   This will create a single, self-contained, executable in a new `dist/` folder. Now trying running:
   ```
   dist\bw.exe -f .gitignore
   ```
   This will run a lot faster. (Slower on the first run, but very very fast on subsequent runs).

