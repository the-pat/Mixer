module ArrayX.Tests

open System.Collections.Generic
open Xunit
open Mixer.Core

[<Fact>]
let ``ArrayX.range 0 0 returns seq { 0 }`` () =
    let expected = seq { 0 }

    let actual = ArrayX.range 0 0

    Assert.Equal<IEnumerable<int>>(expected, actual)

[<Fact>]
let ``ArrayX.range 1 3 returns seq { 1; 2; 3 }`` () =
    let expected =
        seq {
            1
            2
            3
        }

    let actual = ArrayX.range 1 3

    Assert.Equal<IEnumerable<int>>(expected, actual)

[<Fact>]
let ``ArrayX.range 5 3 returns seq { 5; 4; 3 }`` () =
    let expected =
        seq {
            5
            4
            3
        }

    let actual = ArrayX.range 5 3

    Assert.Equal<IEnumerable<int>>(expected, actual)

[<Fact>]
let ``ArrayX.shuffle2 returns the expected sequence`` () =
    let rnd = System.Random(0)

    let expected =
        seq {
            3
            0
            2
            1
        }

    let actual = ArrayX.shuffle2 rnd ([| 0 .. 3 |])

    Assert.Equal<IEnumerable<int>>(expected, actual)

[<Fact>]
let ``ArrayX.shuffle returns the sequence with the expected values`` () =
    let arr = [| 1 .. 10_000 |]
    let expectedValues = Set.ofArray arr

    let actual = ArrayX.shuffle arr

    Assert.All(actual, (fun elem -> Assert.True(Set.contains elem expectedValues)))
