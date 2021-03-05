module ListX.Tests

open System.Collections.Generic
open Xunit
open Mixer.Core

[<Fact>]
let ``ListX.shuffledList 1 10_0000 returns a shuffled list with values between 1 and 10,000 inclusive`` () =
    let expectedValues = Set.ofSeq { 1 .. 10_000 }

    let actual : int list = ListX.shuffledList 1 10_000

    Assert.All(actual, (fun elem -> Assert.True(Set.contains elem expectedValues)))

[<Fact>]
let ``ListX.shuffledList 1 10_0000 run twice does not return the same result`` () =
    let shuffled1 = ListX.shuffledList 1 10_000
    let shuffled2 = ListX.shuffledList 1 10_000

    Assert.NotEqual<IEnumerable<int>>(shuffled1, shuffled2)
