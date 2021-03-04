module ListX.Tests

open Xunit
open Mixer.Core

[<Fact>]
let ``ListX.shuffled 1 10_0000 returns a shuffled list with values between 1 and 10,000 inclusive`` () =
    let expectedValues = Set.ofSeq { 1 .. 10_000 }

    let actual = ListX.shuffledList 1 10_000

    Assert.IsType<int list>(actual)
    Assert.All(actual, (fun elem -> Assert.True(Set.contains elem expectedValues)))
