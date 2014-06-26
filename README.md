ObjectCalisthenicsCodingDojo
============================
This repo contains the tests we use to guide a coding dojo we're holding at Infi (http://www.infi.nl) on the 25th of june 2014.

To actually do the dojo, first read this http://www.cs.helsinki.fi/u/luontola/tdd-2009/ext/ObjectCalisthenics.pdf for the basics on object calisthenics. Then in TDD style complete a tennis scoring application which can do scoring within a set (so it can count points within a game, and the total number of games). 

To help get you started, we already provided some tests in TennisMatchCodingDojo.Tests\Tests.cs. You can use those to guide your TDD effort, or you can think up the tests yourself and use our tests as acceptance tests. For the actual coding dojo we're holding, implementing deuce is optional (so the first player to score on 40 40 wins the game).

The current code base is in Dutch, but will probably be fairly easy to use if you use the following translations (these are the words used in the public API):
* Speler = Player
* BerekenScore = CalculateScore
* ScorePuntVoor = ScorePointFor

Implementations
---------------
This repository is a fork of the [original repository by Freek Paans](https://github.com/FreekPaans/ObjectCalisthenicsCodingDojo). This particular implementation was done during the aforementioned coding dojo by Daniel Bronk and Roeland van Houte. Other implementations well be linked from the original repository.
